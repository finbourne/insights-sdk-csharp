/*
 * FINBOURNE Insights API
 *
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SdkConfiguration = Finbourne.Insights.Sdk.Client.Configuration;
using Microsoft.Extensions.Configuration;

namespace Finbourne.Insights.Sdk.Extensions
{
    /// <summary>
    /// Creates an ApiConfiguration 
    /// </summary>
    public class ApiConfigurationBuilder
    {
        private static readonly Dictionary<string, string> ConfigNamesToEnvVariables = new Dictionary<string, string>()
            {
                { nameof(ApiConfiguration.TokenUrl), "FBN_TOKEN_URL" },
                { nameof(ApiConfiguration.BaseUrl), "FBN_INSIGHTS_URL" },
                { nameof(ApiConfiguration.ClientId), "FBN_CLIENT_ID" },
                { nameof(ApiConfiguration.ClientSecret), "FBN_CLIENT_SECRET" },
                { nameof(ApiConfiguration.Username), "FBN_USERNAME" },
                { nameof(ApiConfiguration.Password), "FBN_PASSWORD" },
                { nameof(ApiConfiguration.PersonalAccessToken), "FBN_ACCESS_TOKEN" },
                { nameof(ApiConfiguration.TimeoutMs), "FBN_TIMEOUT_MS" },
                { nameof(ApiConfiguration.RateLimitRetries), "FBN_RATE_LIMIT_RETRIES" },
            };

        private static readonly Dictionary<string, string> ConfigNamesToSecrets = new Dictionary<string, string>()
        {
            { nameof(ApiConfiguration.TokenUrl), "tokenUrl" },
            { nameof(ApiConfiguration.BaseUrl), "insightsUrl" },
            { nameof(ApiConfiguration.ClientId), "clientId" },
            { nameof(ApiConfiguration.ClientSecret), "clientSecret" },
            { nameof(ApiConfiguration.Username), "username" },
            { nameof(ApiConfiguration.Password), "password" },
            { nameof(ApiConfiguration.PersonalAccessToken), "accessToken" },
            { nameof(ApiConfiguration.TimeoutMs), "timeoutMs" },
            { nameof(ApiConfiguration.RateLimitRetries), "rateLimitRetries" },
        };

        /// <summary>
        /// Builds an ApiConfiguration. using the supplied configuration file (if supplied)
        /// or environment variables.
        ///
        /// <seealso href="https://github.com/finbourne/lusid-sdk-csharp/wiki/API-credentials">For further details refer to wiki article.</seealso>
        /// </summary>
        /// <param name="apiSecretsFilename">filename of the secrets.json</param>
        /// <returns>ApiConfiguration object</returns>
        public static ApiConfiguration Build(string apiSecretsFilename, ConfigurationOptions? opts = null)
        {
            var result = BuildFromSecretsFile(apiSecretsFilename, opts);
            result = result.HasMissingConfig() ? BuildFromEnvironmentVariables(opts) : result;
            return result;
        }

        /// <summary>
        /// Builds an ApiConfiguration using the supplied configuration section.
        ///
        /// <seealso href="https://github.com/finbourne/lusid-sdk-csharp/wiki/API-credentials">For further details refer to wiki article.</seealso>
        /// </summary>
        /// <param name="config">section of ASP Core configuration with required fields</param>
        /// <returns>ApiConfiguration object</returns>
        public static ApiConfiguration BuildFromConfiguration(IConfigurationSection config, ConfigurationOptions? opts = null)
        {
            if (config == null) throw new ArgumentNullException(nameof(config));

            var apiConfig = new ApiConfiguration();
            config.Bind(apiConfig);

            apiConfig = CheckBaseUrl(apiConfig);

            var errors = new List<string>();
            if (apiConfig.HasMissingConfig())
            {
                errors.AddRange(apiConfig.GetMissingConfig()
                    .Select(value => $"'{value}' was not set"));
            }
            
            if (opts != null)
            {
                if (opts.TimeoutMs != null)
                {
                    apiConfig.TimeoutMs = opts.TimeoutMs;
                }

                if (opts.RateLimitRetries != null)
                {
                    apiConfig.RateLimitRetries = opts.RateLimitRetries;
                }
            }
            
            if (apiConfig.TimeoutMs is < 1)
            {
                errors.Add($"'{nameof(apiConfig.TimeoutMs)}' must be a positive integer between 1 and {int.MaxValue}");
            }
                
            if (apiConfig.RateLimitRetries is < 0)
            {
                errors.Add($"'{nameof(apiConfig.RateLimitRetries)}' must be a positive integer between 0 and {int.MaxValue}");
            }

            if (errors.Any())
            {
                throw new ConfigurationException($"The provided configuration section is not valid. The following issues were detected: {string.Join("; ", errors)}");
            }
            
            return apiConfig;
        }        

        private static ApiConfiguration BuildFromEnvironmentVariables(ConfigurationOptions? opts)
        {
            var errors = new List<string>();
            var apiConfig = new ApiConfiguration
            {
                TokenUrl = Environment.GetEnvironmentVariable("FBN_TOKEN_URL") ?? Environment.GetEnvironmentVariable("fbn_token_url"),
                BaseUrl = Environment.GetEnvironmentVariable("FBN_INSIGHTS_URL") ??
                          Environment.GetEnvironmentVariable("FBN_FINBOURNE-INSIGHTS_API_URL") ?? 
                          Environment.GetEnvironmentVariable("fbn_finbourne-insights_api_url") ?? 
                          Environment.GetEnvironmentVariable("FBN_FINBOURNE_INSIGHTS_API_URL") ?? 
                          Environment.GetEnvironmentVariable("fbn_finbourne_insights_api_url"),
                ClientId = Environment.GetEnvironmentVariable("FBN_CLIENT_ID") ?? Environment.GetEnvironmentVariable("fbn_client_id"),
                ClientSecret = Environment.GetEnvironmentVariable("FBN_CLIENT_SECRET") ?? Environment.GetEnvironmentVariable("fbn_client_secret"),
                Username = Environment.GetEnvironmentVariable("FBN_USERNAME") ?? Environment.GetEnvironmentVariable("fbn_username"),
                Password = Environment.GetEnvironmentVariable("FBN_PASSWORD") ?? Environment.GetEnvironmentVariable("fbn_password"),
                ApplicationName = Environment.GetEnvironmentVariable("FBN_APP_NAME") ?? Environment.GetEnvironmentVariable("fbn_app_name"),
                PersonalAccessToken = Environment.GetEnvironmentVariable("FBN_ACCESS_TOKEN") ?? Environment.GetEnvironmentVariable("fbn_access_token"),
            };

            apiConfig.TimeoutMs = GetPositiveIntegerEnvVarValue(ConfigNamesToEnvVariables[nameof(ApiConfiguration.TimeoutMs)], errors, 1, SdkConfiguration.DefaultTimeoutMs);
            apiConfig.RateLimitRetries = GetPositiveIntegerEnvVarValue(ConfigNamesToEnvVariables[nameof(ApiConfiguration.RateLimitRetries)], errors, 0, SdkConfiguration.DefaultRateLimitRetries);
            
            if (opts != null)
            {
                if (opts.TimeoutMs != null)
                {
                    apiConfig.TimeoutMs = opts.TimeoutMs;
                }

                if (opts.RateLimitRetries != null)
                {
                    apiConfig.RateLimitRetries = opts.RateLimitRetries;
                }
            }

            if (apiConfig.HasMissingConfig())
            {
                errors.AddRange(apiConfig.GetMissingConfig()
                    .Select(value => $"'{ConfigNamesToEnvVariables[value]}' was not set"));
            }

            if (errors.Any())
            {
                throw new ConfigurationException($"Configuration parameters are not valid. The following issues were detected with the environment variables set: {string.Join("; ", errors)}");
            }

            return apiConfig;
        }

        private static int GetPositiveIntegerEnvVarValue(string envVarName, List<string> errors, int minimumAllowedValue, int defaultValue)
        {
            var envVarValueString = Environment.GetEnvironmentVariable(envVarName) ??
                                  Environment.GetEnvironmentVariable(envVarName.ToLower());
            if (envVarValueString == null)
            {
                return defaultValue;
            }
            if (int.TryParse(envVarValueString, out var envVarValueInt))
            {
                if (envVarValueInt < minimumAllowedValue)
                {
                    errors.Add($"'{envVarName}' must be a positive integer between {minimumAllowedValue} and {int.MaxValue}");
                }
                else
                {
                    return envVarValueInt;
                }
            }
            else
            {
                errors.Add($"'{envVarName}' is not a valid integer");
            }
            return defaultValue;
        }

        private static ApiConfiguration BuildFromSecretsFile(string apiSecretsFilename, ConfigurationOptions? opts)
        {
            var errors = new List<string>();
            var apiConfig = new ApiConfiguration();
            if (apiSecretsFilename != null &&
                File.Exists(Path.Combine(Directory.GetCurrentDirectory(), apiSecretsFilename)))
            {
                var config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile(apiSecretsFilename)
                    .Build();
                config.GetSection("api").Bind(apiConfig);

                apiConfig = CheckBaseUrl(apiConfig);
                
                if (apiConfig.HasMissingConfig())
                {
                    errors.AddRange(apiConfig.GetMissingConfig()
                        .Select(value => $"'api.{ConfigNamesToSecrets[value]}' was not set"));
                }
            }

            if (opts != null)
            {
                if (opts.TimeoutMs != null)
                {
                    apiConfig.TimeoutMs = opts.TimeoutMs;
                }

                if (opts.RateLimitRetries != null)
                {
                    apiConfig.RateLimitRetries = opts.RateLimitRetries;
                }
            }
            
            if (apiConfig.TimeoutMs is < 1)
            {
                errors.Add($"'api.{ConfigNamesToSecrets[nameof(apiConfig.TimeoutMs)]}' must be a positive integer between 1 and {int.MaxValue}");
            }
                
            if (apiConfig.RateLimitRetries is < 0)
            {
                errors.Add($"'api.{ConfigNamesToSecrets[nameof(apiConfig.RateLimitRetries)]}' must be a positive integer between 0 and {int.MaxValue}");
            }

            if (errors.Any())
            {
                throw new ConfigurationException($"The provided configuration file '{apiSecretsFilename}' is not valid. The following issues were detected: {string.Join("; ", errors)}");
            }

            return apiConfig;
        }

        private static ApiConfiguration CheckBaseUrl(ApiConfiguration parsedConfig) 
        {
            if(string.IsNullOrWhiteSpace(parsedConfig.BaseUrl))
            {
                parsedConfig.BaseUrl = string.IsNullOrWhiteSpace(parsedConfig.SnakeCaseBaseUrl)
                    ? parsedConfig.LowerCaseBaseUrl : parsedConfig.SnakeCaseBaseUrl;
            }

            return parsedConfig;
        }
    }
}