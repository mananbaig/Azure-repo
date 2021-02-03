﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text.Json;

namespace Azure.Communication
{
    internal class CommunicationIdentifierSerializer
    {
        public static CommunicationIdentifier Deserialize(CommunicationIdentifierModel identifier)
        {
            string rawId = AssertNotNull(identifier.RawId, nameof(identifier.RawId), nameof(CommunicationIdentifierModel));

            if (identifier.CommunicationUser is CommunicationUserIdentifierModel user)
                return new CommunicationUserIdentifier(AssertNotNull(user.Id, nameof(user.Id), nameof(CommunicationUserIdentifierModel)));

            if (identifier.PhoneNumber is PhoneNumberIdentifierModel phoneNumber)
            {
                return new PhoneNumberIdentifier(
                    AssertNotNull(phoneNumber.Value, nameof(phoneNumber.Value), nameof(PhoneNumberIdentifierModel)),
                    AssertNotNull(identifier.RawId, nameof(identifier.RawId), nameof(PhoneNumberIdentifierModel)));
            }

            if (identifier.MicrosoftTeamsUser is MicrosoftTeamsUserIdentifierModel teamsUser)
            {
                return new MicrosoftTeamsUserIdentifier(
                    AssertNotNull(teamsUser.UserId, nameof(teamsUser.UserId), nameof(MicrosoftTeamsUserIdentifierModel)),
                    AssertNotNull(teamsUser.IsAnonymous, nameof(teamsUser.IsAnonymous), nameof(MicrosoftTeamsUserIdentifierModel)),
                    Deserialize(AssertNotNull(teamsUser.Cloud, nameof(teamsUser.Cloud), nameof(MicrosoftTeamsUserIdentifierModel))),
                    rawId);
            }

            return new UnknownIdentifier(rawId);
        }

        private static CommunicationCloudEnvironment Deserialize(CommunicationCloudEnvironmentModel cloud)
        {
            if (cloud == CommunicationCloudEnvironmentModel.Public)
                return CommunicationCloudEnvironment.Public;
            if (cloud == CommunicationCloudEnvironmentModel.Gcch)
                return CommunicationCloudEnvironment.Gcch;
            if (cloud == CommunicationCloudEnvironmentModel.Dod)
                return CommunicationCloudEnvironment.Dod;

            return new CommunicationCloudEnvironment(cloud.ToString());
        }

        public static CommunicationIdentifierModel Serialize(CommunicationIdentifier identifier)
            => identifier switch
            {
                CommunicationUserIdentifier u => new CommunicationIdentifierModel
                {
                    CommunicationUser = new CommunicationUserIdentifierModel
                    {
                        Id = u.Id,
                    }
                },
                PhoneNumberIdentifier p => new CommunicationIdentifierModel
                {
                    RawId = p.RawId,
                    PhoneNumber = new PhoneNumberIdentifierModel
                    {
                        Value = p.PhoneNumber,
                    },
                },
                MicrosoftTeamsUserIdentifier u => new CommunicationIdentifierModel
                {
                    RawId = u.RawId,
                    MicrosoftTeamsUser = new MicrosoftTeamsUserIdentifierModel
                    {
                        UserId = u.UserId,
                        IsAnonymous = u.IsAnonymous,
                        Cloud = Serialize(u.Cloud),
                    }
                },
                UnknownIdentifier u => new CommunicationIdentifierModel
                {
                    RawId = u.Id
                },
                _ => throw new NotSupportedException(),
            };

        private static CommunicationCloudEnvironmentModel Serialize(CommunicationCloudEnvironment cloud)
        {
            if (cloud == CommunicationCloudEnvironment.Public)
                return CommunicationCloudEnvironmentModel.Public;
            if (cloud == CommunicationCloudEnvironment.Gcch)
                return CommunicationCloudEnvironmentModel.Gcch;
            if (cloud == CommunicationCloudEnvironment.Dod)
                return CommunicationCloudEnvironmentModel.Dod;

            return new CommunicationCloudEnvironmentModel(cloud.ToString());
        }

        private static T AssertNotNull<T>(T value, string name, string type) where T : class?
            => value ?? throw new JsonException($"Property '{name}' is required for identifier of type `{type}`.");

        private static T AssertNotNull<T>(T? value, string name, string type) where T : struct
        {
            if (value is null)
                throw new JsonException($"Property '{name}' is required for identifier of type `{type}`.");

            return value.Value;
        }
    }
}
