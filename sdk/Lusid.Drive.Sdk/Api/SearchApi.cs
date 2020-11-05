/* 
 * FINBOURNE Drive API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.95
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using Lusid.Drive.Sdk.Client;
using Lusid.Drive.Sdk.Model;

namespace Lusid.Drive.Sdk.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISearchApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [EXPERIMENTAL] Search for a file or folder with a given name and path
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Lusid.Drive.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchBody">Search parameters</param>
        /// <param name="page"> (optional)</param>
        /// <param name="sortBy"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="filter"> (optional, default to &quot;&quot;)</param>
        /// <returns>PagedResourceListOfStorageObject</returns>
        PagedResourceListOfStorageObject Search (SearchBody searchBody, string page = null, List<string> sortBy = null, int? limit = null, string filter = null);

        /// <summary>
        /// [EXPERIMENTAL] Search for a file or folder with a given name and path
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Lusid.Drive.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchBody">Search parameters</param>
        /// <param name="page"> (optional)</param>
        /// <param name="sortBy"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="filter"> (optional, default to &quot;&quot;)</param>
        /// <returns>ApiResponse of PagedResourceListOfStorageObject</returns>
        ApiResponse<PagedResourceListOfStorageObject> SearchWithHttpInfo (SearchBody searchBody, string page = null, List<string> sortBy = null, int? limit = null, string filter = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// [EXPERIMENTAL] Search for a file or folder with a given name and path
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Lusid.Drive.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchBody">Search parameters</param>
        /// <param name="page"> (optional)</param>
        /// <param name="sortBy"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="filter"> (optional, default to &quot;&quot;)</param>
        /// <returns>Task of PagedResourceListOfStorageObject</returns>
        System.Threading.Tasks.Task<PagedResourceListOfStorageObject> SearchAsync (SearchBody searchBody, string page = null, List<string> sortBy = null, int? limit = null, string filter = null);

        /// <summary>
        /// [EXPERIMENTAL] Search for a file or folder with a given name and path
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Lusid.Drive.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchBody">Search parameters</param>
        /// <param name="page"> (optional)</param>
        /// <param name="sortBy"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="filter"> (optional, default to &quot;&quot;)</param>
        /// <returns>Task of ApiResponse (PagedResourceListOfStorageObject)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagedResourceListOfStorageObject>> SearchAsyncWithHttpInfo (SearchBody searchBody, string page = null, List<string> sortBy = null, int? limit = null, string filter = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SearchApi : ISearchApi
    {
        private Lusid.Drive.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SearchApi(String basePath)
        {
            this.Configuration = new Lusid.Drive.Sdk.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Lusid.Drive.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class
        /// </summary>
        /// <returns></returns>
        public SearchApi()
        {
            this.Configuration = Lusid.Drive.Sdk.Client.Configuration.Default;

            ExceptionFactory = Lusid.Drive.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SearchApi(Lusid.Drive.Sdk.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Lusid.Drive.Sdk.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Lusid.Drive.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Lusid.Drive.Sdk.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Lusid.Drive.Sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// [EXPERIMENTAL] Search for a file or folder with a given name and path 
        /// </summary>
        /// <exception cref="Lusid.Drive.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchBody">Search parameters</param>
        /// <param name="page"> (optional)</param>
        /// <param name="sortBy"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="filter"> (optional, default to &quot;&quot;)</param>
        /// <returns>PagedResourceListOfStorageObject</returns>
        public PagedResourceListOfStorageObject Search (SearchBody searchBody, string page = null, List<string> sortBy = null, int? limit = null, string filter = null)
        {
             ApiResponse<PagedResourceListOfStorageObject> localVarResponse = SearchWithHttpInfo(searchBody, page, sortBy, limit, filter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// [EXPERIMENTAL] Search for a file or folder with a given name and path 
        /// </summary>
        /// <exception cref="Lusid.Drive.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchBody">Search parameters</param>
        /// <param name="page"> (optional)</param>
        /// <param name="sortBy"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="filter"> (optional, default to &quot;&quot;)</param>
        /// <returns>ApiResponse of PagedResourceListOfStorageObject</returns>
        public ApiResponse< PagedResourceListOfStorageObject > SearchWithHttpInfo (SearchBody searchBody, string page = null, List<string> sortBy = null, int? limit = null, string filter = null)
        {
            // verify the required parameter 'searchBody' is set
            if (searchBody == null)
                throw new ApiException(400, "Missing required parameter 'searchBody' when calling SearchApi->Search");

            var localVarPath = "./api/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (sortBy != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "sortBy", sortBy)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (filter != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter
            if (searchBody != null && searchBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(searchBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = searchBody; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-SDK-Language"] = "C#";
            localVarHeaderParams["X-LUSID-SDK-Version"] = "0.1.95";

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Search", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PagedResourceListOfStorageObject>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PagedResourceListOfStorageObject) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagedResourceListOfStorageObject)));
        }

        /// <summary>
        /// [EXPERIMENTAL] Search for a file or folder with a given name and path 
        /// </summary>
        /// <exception cref="Lusid.Drive.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchBody">Search parameters</param>
        /// <param name="page"> (optional)</param>
        /// <param name="sortBy"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="filter"> (optional, default to &quot;&quot;)</param>
        /// <returns>Task of PagedResourceListOfStorageObject</returns>
        public async System.Threading.Tasks.Task<PagedResourceListOfStorageObject> SearchAsync (SearchBody searchBody, string page = null, List<string> sortBy = null, int? limit = null, string filter = null)
        {
             ApiResponse<PagedResourceListOfStorageObject> localVarResponse = await SearchAsyncWithHttpInfo(searchBody, page, sortBy, limit, filter);
             return localVarResponse.Data;

        }

        /// <summary>
        /// [EXPERIMENTAL] Search for a file or folder with a given name and path 
        /// </summary>
        /// <exception cref="Lusid.Drive.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchBody">Search parameters</param>
        /// <param name="page"> (optional)</param>
        /// <param name="sortBy"> (optional)</param>
        /// <param name="limit"> (optional)</param>
        /// <param name="filter"> (optional, default to &quot;&quot;)</param>
        /// <returns>Task of ApiResponse (PagedResourceListOfStorageObject)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagedResourceListOfStorageObject>> SearchAsyncWithHttpInfo (SearchBody searchBody, string page = null, List<string> sortBy = null, int? limit = null, string filter = null)
        {
            // verify the required parameter 'searchBody' is set
            if (searchBody == null)
                throw new ApiException(400, "Missing required parameter 'searchBody' when calling SearchApi->Search");

            var localVarPath = "./api/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (sortBy != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "sortBy", sortBy)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (filter != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter
            if (searchBody != null && searchBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(searchBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = searchBody; // byte array
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            //  set the LUSID header
            localVarHeaderParams["X-LUSID-Sdk-Language"] = "C#";
            localVarHeaderParams["X-LUSID-Sdk-Version"] = "0.1.95";

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Search", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PagedResourceListOfStorageObject>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PagedResourceListOfStorageObject) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagedResourceListOfStorageObject)));
        }

    }
}