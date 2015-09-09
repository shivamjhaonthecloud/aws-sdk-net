/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Container for the parameters to the ListDomains operation.
    /// Returns the list of domains registered in the account. The results may be split into
    /// multiple pages. To retrieve subsequent pages, make the call again using the nextPageToken
    /// returned by the initial call.
    /// 
    ///  <note> This operation is eventually consistent. The results are best effort and may
    /// not exactly reflect recent updates and changes.</note> 
    /// <para>
    /// <b>Access Control</b>
    /// </para>
    ///  
    /// <para>
    /// You can use IAM policies to control this action's access to Amazon SWF resources as
    /// follows:
    /// </para>
    ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
    /// to only specified domains. The element must be set to <code>arn:aws:swf::AccountID:domain/*</code>,
    /// where <i>AccountID</i> is the account ID, with no dashes.</li> <li>Use an <code>Action</code>
    /// element to allow or deny permission to call this action.</li> <li>You cannot use an
    /// IAM policy to constrain this action's parameters.</li> </ul> 
    /// <para>
    /// If the caller does not have sufficient permissions to invoke the action, or the parameter
    /// values fall outside the specified constraints, the action fails. The associated event
    /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
    /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
    /// IAM to Manage Access to Amazon SWF Workflows</a>.
    /// </para>
    /// </summary>
    public partial class ListDomainsRequest : AmazonSimpleWorkflowRequest
    {
        private int? _maximumPageSize;
        private string _nextPageToken;
        private RegistrationStatus _registrationStatus;
        private bool? _reverseOrder;

        /// <summary>
        /// Gets and sets the property MaximumPageSize. 
        /// <para>
        /// The maximum number of results that will be returned per call. <code>nextPageToken</code>
        /// can be used to obtain futher pages of results. The default is 1000, which is the maximum
        /// allowed page size. You can, however, specify a page size <i>smaller</i> than the maximum.
        /// </para>
        ///  
        /// <para>
        /// This is an upper limit only; the actual number of results returned per call may be
        /// fewer than the specified maximum.
        /// </para>
        /// </summary>
        public int MaximumPageSize
        {
            get { return this._maximumPageSize.GetValueOrDefault(); }
            set { this._maximumPageSize = value; }
        }

        // Check to see if MaximumPageSize property is set
        internal bool IsSetMaximumPageSize()
        {
            return this._maximumPageSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// If a <code>NextPageToken</code> was returned by a previous call, there are more results
        /// available. To retrieve the next page of results, make the call again using the returned
        /// token in <code>nextPageToken</code>. Keep all other arguments unchanged.
        /// </para>
        ///  
        /// <para>
        /// The configured <code>maximumPageSize</code> determines how many results can be returned
        /// in a single call.
        /// </para>
        /// </summary>
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

        /// <summary>
        /// Gets and sets the property RegistrationStatus. 
        /// <para>
        /// Specifies the registration status of the domains to list.
        /// </para>
        /// </summary>
        public RegistrationStatus RegistrationStatus
        {
            get { return this._registrationStatus; }
            set { this._registrationStatus = value; }
        }

        // Check to see if RegistrationStatus property is set
        internal bool IsSetRegistrationStatus()
        {
            return this._registrationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ReverseOrder. 
        /// <para>
        /// When set to <code>true</code>, returns the results in reverse order. By default, the
        /// results are returned in ascending alphabetical order by <code>name</code> of the domains.
        /// </para>
        /// </summary>
        public bool ReverseOrder
        {
            get { return this._reverseOrder.GetValueOrDefault(); }
            set { this._reverseOrder = value; }
        }

        // Check to see if ReverseOrder property is set
        internal bool IsSetReverseOrder()
        {
            return this._reverseOrder.HasValue; 
        }

    }
}