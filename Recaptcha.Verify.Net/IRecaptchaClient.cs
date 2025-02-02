﻿using Recaptcha.Verify.Net.Models.Request;
using Recaptcha.Verify.Net.Models.Response;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Recaptcha.Verify.Net
{
    /// <summary>
    /// Http client for verifying reCAPTCHA response token.
    /// </summary>
    public interface IRecaptchaClient
    {
        /// <summary>
        /// Verifies reCAPTCHA response token.
        /// https://developers.google.com/recaptcha/docs/verify#api-request
        /// </summary>
        /// <param name="request">Verify reCAPTCHA response token request params.</param>
        /// <returns>A <see cref="VerifyResponse"/> verification response.</returns>
        [Post("/siteverify")]
        Task<VerifyResponse> VerifyAsync(
            [Body(BodySerializationMethod.UrlEncoded)] VerifyRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Verifies reCAPTCHA V3 response token.
        /// https://developers.google.com/recaptcha/docs/verify#api-request
        /// </summary>
        /// <param name="request">Verify reCAPTCHA V3 response token request params.</param>
        /// <returns>A <see cref="VerifyResponseV3"/> verification response.</returns>
        [Post("/siteverify")]
        Task<VerifyResponseV3> VerifyV3Async(
            [Body(BodySerializationMethod.UrlEncoded)] VerifyRequest request,
            CancellationToken cancellationToken = default);
    }
}
