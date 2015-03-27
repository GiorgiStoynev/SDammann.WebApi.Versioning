﻿#if WWW
namespace SDammann.WebApi.Versioning.TestApi.Api.Version1 {
#else
namespace SDammann.WebApi.Versioning.Tests.Integration.Controllers.Version1 {
#endif
    using System.Web.Http;

    /// <summary>
    /// Hello controller version 1 description
    /// </summary>
    /// <remarks>
    /// Hello controller version 1 remarks
    /// </remarks>
    public sealed class HelloController : ApiController {
        /// <summary>
        /// Hello controller version 1 'GET' method description
        /// </summary>
        /// <returns>Description of return value</returns>
        public string Get() {
            return "Version1.0";
        }
    }
}