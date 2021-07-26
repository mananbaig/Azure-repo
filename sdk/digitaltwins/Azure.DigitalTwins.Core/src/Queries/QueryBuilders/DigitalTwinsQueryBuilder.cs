﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Azure.DigitalTwins.Core.QueryBuilder
{
    /// <summary>
    /// Azure DigitalTwins Query builder that facilitates writing queries against ADT instances.
    /// </summary>
    public class DigitalTwinsQueryBuilder
    {
        private List<SelectClause> _selectClauses;
        private List<string> _selectAsClauses;
        private readonly string _alias;

        private FromClause _fromClause;
        private WhereQuery _whereQuery;

        private string _queryText;

        /// <summary>
        /// Create a Digital Twins query without automatically specifiying or aliasing a queryable collection.
        /// </summary>
        public DigitalTwinsQueryBuilder()
        {
            _selectClauses = new List<SelectClause>();
            _selectAsClauses = new List<string>();
            _whereQuery = new WhereQuery();
        }

        /// <summary>
        /// Create a Digital Twins query and automatically specify a queryable collection and (optionally) specify a collection alias.
        /// </summary>
        /// <param name="collection"> Collection to query from. </param>
         /// <param name="alias"> Alias for queryable collection. </param>
        public DigitalTwinsQueryBuilder(AdtCollection collection, string alias = null)
        {
            _selectClauses = new List<SelectClause>();
            _selectAsClauses = new List<string>();
            _alias = alias;
            _fromClause = new FromClause(collection);
            _whereQuery = new WhereQuery();
        }

        /// <summary>
        /// Specifies the list of columns that the query will return.
        /// </summary>
        /// <param name="args">The arguments that can be queried (e.g., *, somePropertyName, etc.)</param>
        /// <returns> Query that contains a select clause. </returns>
        public DigitalTwinsQueryBuilder Select(params string[] args)
        {
            _selectClauses.Add(new SelectClause(args));
            return this;
        }

        /// <summary>
        /// Specifies the list of all possible columns to return.
        /// </summary>
        /// <returns> Query that contains a select clause. </returns>
        public DigitalTwinsQueryBuilder SelectAll()
        {
            _selectClauses.Add(new SelectClause(new string[] { "*" }));
            return this;
        }

        /// <summary>
        /// Used when applying the <see href="https://docs.microsoft.com/en-us/azure/digital-twins/reference-query-clause-select#select-top">TOP()</see> aggregate from the ADT query language. Same functionality as <see cref="Select(params string[])"/>
        /// but inserts TOP() into the query structure as well as well as specific properties to select.
        /// </summary>
        /// <param name="count">The argument for TOP(), i.e. the number of instances to return.</param>
        /// <param name="args">The arguments that can be optionally passed with top (e.g., property name).</param>
        /// <returns> Query that contains a select clause. </returns>
        public DigitalTwinsQueryBuilder SelectTop(int count, params string[] args)
        {
            var topArg = new StringBuilder().Append($"{QueryConstants.Top}({count})").Append(' ');

            // append optional arguments separated by commas
            topArg.Append(string.Join(", ", args));
            _selectClauses.Add(new SelectClause(new string[] { topArg.ToString() }));

            return this;
        }

        /// <summary>
        /// Used when applying the <see href="https://docs.microsoft.com/en-us/azure/digital-twins/reference-query-clause-select#select-top">TOP()</see> aggregate from the ADT query language. Same functionality as select
        /// but inserts TOP() into the query structure as well.
        /// </summary>
        /// <param name="count">The argument for TOP(), i.e. the number of results to return.</param>
        /// <returns> Query that contains a select clause. </returns>
        public DigitalTwinsQueryBuilder SelectTopAll(int count)
        {
            // turn into correct format -- eg. SELECT TOP(3)
            var topArg = new StringBuilder().Append($"{QueryConstants.Top}({count})");
            _selectClauses.Add(new SelectClause(new string[] { topArg.ToString() }));

            return this;
        }

        /// <summary>
        /// Used when applying the <see href="https://docs.microsoft.com/en-us/azure/digital-twins/reference-query-clause-select#select-count">COUNT()</see> aggregate from the ADT query language.
        /// </summary>
        /// <returns> Query that contains a select clause. </returns>
        public DigitalTwinsQueryBuilder SelectCount()
        {
            string countArg = $"{QueryConstants.Count}()";

            _selectClauses.Add(new SelectClause(new string[] { countArg }));
            return this;
        }

        /// <summary>
        /// Used when overriding the query builder with the literal query string.
        /// </summary>
        /// <param name="customQuery">Query in string format.</param>
        /// <returns> Query that contains a select clause. </returns>
        public DigitalTwinsQueryBuilder SelectCustom(string customQuery)
        {
            _selectClauses.Add(new SelectClause(new string[] { customQuery }));
            return this;
        }

        /// <summary>
        /// Used to select properties with the desired alias.
        /// </summary>
        /// <param name="field">The proper name for the selectable property in the ADT Query Language.</param>
        /// <param name="alias">The alias to be assigned to the return contents in the query response.</param>
        /// <returns> Query that contains an aliased select clause. </returns>
        public DigitalTwinsQueryBuilder SelectAs(string field, string alias)
        {
            _selectAsClauses.Add($"{field} {QueryConstants.As} {alias}");
            return this;
        }

        /// <summary>
        /// Adds the FROM clause and its argument to the query via the Clauses component.
        /// </summary>
        /// <param name="collection">Collection that can be used as query source.</param>
        /// <returns> ADT query a from clause. </returns>
        public DigitalTwinsQueryBuilder From(AdtCollection collection)
        {
            _fromClause = new FromClause(collection);
            return this;
        }

        /// <summary>
        /// Adds the FROM clause, its argument, and an alias for its argument into the query.
        /// </summary>
        /// <param name="collection">The collection being queried from.</param>
        /// <param name="alias">The alias being assigned to the collection being queried from.</param>
        /// <returns> ADT query with a from clause. </returns>
        public DigitalTwinsQueryBuilder From(AdtCollection collection, string alias)
        {
            _fromClause = new FromClause(collection, alias);
            return this;
        }

        /// <summary>
        /// An overloaded alternative to passing in a Collection that allows for simply passing in the string name of the collection
        /// that is being queried.
        /// </summary>
        /// <param name="collection">The name of the collection.</param>
        /// <returns> ADT query with a from clause. </returns>
        public DigitalTwinsQueryBuilder FromCustom(string collection)
        {
            _fromClause = new FromClause(collection);
            return this;
        }

        /// <summary>
        /// Adds a WHERE clause to a query.
        /// </summary>
        /// <param name="whereLogic">Delgate that contains methods from the <see cref="WhereQuery"/> class.</param>
        /// <returns> ADT query with a where clause. </returns>
        public DigitalTwinsQueryBuilder Where(Func<WhereQuery, WhereQuery> whereLogic)
        {
            whereLogic.Invoke(_whereQuery);
            return this;
        }

        /// <summary>
        /// Constructs the string representation of the built query.
        /// </summary>
        /// <returns> DigitalTwinsQueryBuilder with an updated string representation. </returns>
        public DigitalTwinsQueryBuilder Build()
        {
            var queryString = new StringBuilder();

            // Add alias to query string
            bool aliasedCollection = _alias != null;
            bool nonAliasedSelectStatements = _selectClauses.Any();

            if (aliasedCollection && !nonAliasedSelectStatements)
            {
                // if no select statement, build select all by default
                _selectClauses.Add(new SelectClause(new string[] { _alias }));
                nonAliasedSelectStatements = !nonAliasedSelectStatements;
            }

            // Determine basic layout of select clause for spacing and comma purposes
            bool aliasedSelectStatements = _selectAsClauses.Any();
            bool nestedQuery = !(aliasedSelectStatements || nonAliasedSelectStatements);

            // Add select clauses
            if (!nestedQuery)
            {
                queryString.Append(QueryConstants.Select).Append(' ');
            }

            foreach (SelectClause clause in _selectClauses)
            {
                string selectClauseString;
                if (clause?.ClauseArgs == null)
                {
                    selectClauseString = string.Empty;
                }
                else
                {
                    selectClauseString = string.Join(", ", clause?.ClauseArgs);
                }

                queryString.Append(selectClauseString);
            }

            if (aliasedSelectStatements)
            {
                if (nonAliasedSelectStatements)
                {
                    queryString.Append(", ");
                }

                queryString.Append(string.Join(", ", _selectAsClauses));
            }

            // add from clause
            if (!nestedQuery)
            {
                queryString.Append(' ').Append(QueryConstants.From).Append(' ');
                queryString.Append(_fromClause?.Collection).Append(' ');
            }

            if (aliasedCollection)
            {
                queryString.Append(_alias).Append(' ');
            }

            if (_whereQuery != null)
            {
                string whereClauseText = _whereQuery.GetQueryText();

                if (!string.IsNullOrEmpty(whereClauseText))
                {
                    queryString.Append(QueryConstants.Where).Append(' ');
                }

                queryString.Append(whereClauseText);
            }

            _queryText = queryString.ToString().Trim();
            return this;
        }

        /// <summary>
        /// Gets the string representation of the built query.
        /// </summary>
        /// <returns> String represenation of query. </returns>
        public string GetQueryText()
        {
            return _queryText;
        }
    }
}
