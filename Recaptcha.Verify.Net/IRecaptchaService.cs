﻿using Recaptcha.Verify.Net.Exceptions;
using Recaptcha.Verify.Net.Models.Request;
using Recaptcha.Verify.Net.Models.Response;
using System.Threading;
using System.Threading.Tasks;

namespace Recaptcha.Verify.Net
{
    /// <summary>
    /// Service for verifying reCAPTCHA response token.
    /// </summary>
    public interface IRecaptchaService
    {
        /// <summary>
        /// Verifies reCAPTCHA response token.
        /// https://developers.google.com/recaptcha/docs/verify#api-request
        /// </summary>
        /// <param name="request">Verify reCAPTCHA response token request params.</param>
        /// <returns>A <see cref="Task"/> that represents the asynchronous operation.
        /// The task result contains verification response <see cref="VerifyResponse"/>.</returns>
        /// <exception cref="EmptyCaptchaAnswerException">
        /// This exception is thrown when captcha answer is empty.
        /// </exception>
        /// <exception cref="SecretKeyNotSpecifiedException">
        /// This exception is thrown when secret key was not specified in options or request params.
        /// </exception>
        Task<VerifyResponse> VerifyAsync(VerifyRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Verifies reCAPTCHA response token.
        /// https://developers.google.com/recaptcha/docs/verify#api-request
        /// </summary>
        /// <param name="response">The user response token provided by the reCAPTCHA client-side integration on your site.</param>
        /// <param name="secret">The shared key between your site and reCAPTCHA.
        /// This parameter could be unsetted if <see cref="RecaptchaOptions"/> was configured.</param>
        /// <param name="remoteIp">The user's IP address.</param>
        /// <returns>A <see cref="Task"/> that represents the asynchronous operation.
        /// The task result contains verification response <see cref="VerifyResponse"/>.</returns>
        /// <exception cref="EmptyCaptchaAnswerException">
        /// This exception is thrown when captcha answer is empty.
        /// </exception>
        /// <exception cref="SecretKeyNotSpecifiedException">
        /// This exception is thrown when secret key was not specified in options or request params.
        /// </exception>
        Task<VerifyResponse> VerifyAsync(string response, string secret = null,
            string remoteIp = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Verifies reCAPTCHA V3 response token.
        /// </summary>
        /// <seealso cref="VerifyAsync(VerifyRequest, CancellationToken)"/>
        Task<VerifyResponseV3> VerifyV3Async(VerifyRequest request, CancellationToken cancellationToken = default);
    }
}
