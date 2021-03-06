﻿// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Ads.GoogleAds.Examples;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.Tests.V4;
using Google.Ads.GoogleAds.V4.Common;
using Google.Ads.GoogleAds.V4.Enums;
using Google.Ads.GoogleAds.V4.Errors;
using Google.Ads.GoogleAds.V4.Resources;
using Google.Ads.GoogleAds.V4.Services;
using Google.LongRunning;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V4.Enums.AdGroupAdStatusEnum.Types;
using static Google.Ads.GoogleAds.V4.Enums.AdGroupCriterionStatusEnum.Types;
using static Google.Ads.GoogleAds.V4.Enums.AdvertisingChannelTypeEnum.Types;
using static Google.Ads.GoogleAds.V4.Enums.BudgetDeliveryMethodEnum.Types;
using static Google.Ads.GoogleAds.V4.Enums.CampaignExperimentTrafficSplitTypeEnum.Types;
using static Google.Ads.GoogleAds.V4.Enums.CampaignStatusEnum.Types;
using static Google.Ads.GoogleAds.V4.Enums.KeywordMatchTypeEnum.Types;
using static Google.Ads.GoogleAds.V4.Enums.ServedAssetFieldTypeEnum.Types;
using static Google.Ads.GoogleAds.V4.Resources.Campaign.Types;

namespace Google.Ads.GoogleAds.Tests.Examples.V4
{
    internal class ExampleTestsUtils : TestUtils
    {
        /// <summary>
        /// Creates the budget for the campaign.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="isExplicitlyShared">True, if the campaign is shared, false otherwise.
        /// </param>
        /// <returns>The resource name of the newly created campaign budget.</returns>
        internal static string CreateBudget(GoogleAdsClient client, bool isExplicitlyShared = true)
        {
            CampaignBudget budget = new CampaignBudget()
            {
                Name = "Interplanetary Cruise Budget #" + ExampleUtilities.GetRandomString(),
                DeliveryMethod = BudgetDeliveryMethod.Standard,
                AmountMicros = 500000,
                ExplicitlyShared = isExplicitlyShared
            };

            MutateOperation mutateOperation = new MutateOperation()
            {
                CampaignBudgetOperation = new CampaignBudgetOperation()
                {
                    Create = budget,
                },
            };

            return ExecuteOperations(client, new[] { mutateOperation }).First()
                .CampaignBudgetResult.ResourceName;
        }

        /// <summary>
        /// Creates the campaign.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="budgetResourceName">The resource name for the budget.</param>
        /// <returns>The resource name of the newly created campaign.</returns>
        internal static string CreateCampaign(GoogleAdsClient client, string budgetResourceName)
        {
            Campaign campaign = new Campaign()
            {
                Name = "Interplanetary Cruise #" + ExampleUtilities.GetRandomString(),
                AdvertisingChannelType = AdvertisingChannelType.Search,
                Status = CampaignStatus.Paused,
                ManualCpc = new ManualCpc(),
                CampaignBudget = budgetResourceName,
                NetworkSettings = new NetworkSettings
                {
                    TargetGoogleSearch = true,
                    TargetSearchNetwork = true,
                    TargetContentNetwork = false,
                    TargetPartnerSearchNetwork = false
                },
                StartDate = DateTime.Now.AddDays(1).ToString("yyyyMMdd"),
                EndDate = DateTime.Now.AddYears(1).ToString("yyyyMMdd"),
            };

            MutateOperation mutateOperation = new MutateOperation()
            {
                CampaignOperation = new CampaignOperation() { Create = campaign }
            };
            return ExecuteOperations(client, new[] { mutateOperation }).First()
                .CampaignResult.ResourceName;
        }

        /// <summary>
        ///  Creates a new standard shopping campaign in the specified client account.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="budgetResourceName">The resource name of the budget for the campaign.
        /// </param>
        /// <param name="merchantCenterAccountId">The Merchant Center account ID.</param>
        /// <returns>Resource name of the newly created campaign.</returns>
        internal static string CreateStandardShoppingCampaign(GoogleAdsClient client,
            string budgetResourceName, long merchantCenterAccountId)
        {
            Campaign campaign = new Campaign()
            {
                Name = "Interplanetary Cruise #" + ExampleUtilities.GetRandomString(),
                AdvertisingChannelType = AdvertisingChannelType.Shopping,
                ShoppingSetting = new ShoppingSetting()
                {
                    SalesCountry = "US",
                    CampaignPriority = 0,
                    MerchantId = merchantCenterAccountId,
                    EnableLocal = true
                },

                Status = CampaignStatus.Paused,
                ManualCpc = new ManualCpc()
                {
                    EnhancedCpcEnabled = true
                },
                CampaignBudget = budgetResourceName
            };

            MutateOperation mutateOperation = new MutateOperation()
            {
                CampaignOperation = new CampaignOperation() { Create = campaign }
            };
            return ExecuteOperations(client, new[] { mutateOperation }).First()
                .CampaignResult.ResourceName;
        }

        /// <summary>
        /// Creates the ad group.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="campaignResourceName">Resource name of the campaign in which ad group
        /// is created.</param>
        /// <returns>The resource name of the newly created ad group.</returns>
        internal static string CreateAdGroup(GoogleAdsClient client, string campaignResourceName)
        {
            AdGroup adGroup = new AdGroup()
            {
                Name = $"Earth to Mars Cruises #{ExampleUtilities.GetRandomString()}",
                Status = AdGroupStatusEnum.Types.AdGroupStatus.Enabled,
                Campaign = campaignResourceName,
                CpcBidMicros = 10000000
            };

            MutateOperation mutateOperation = new MutateOperation()
            {
                AdGroupOperation = new AdGroupOperation() { Create = adGroup }
            };
            return ExecuteOperations(client, new[] { mutateOperation }).First()
                .AdGroupResult.ResourceName;
        }

        /// <summary>
        /// Creates the responsive search ad.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="adGroupResourceName">Resource name of the ad group in which responsive
        /// search ad is created.</param>
        /// <returns>The resource name of the newly created responsive search ad.</returns>
        internal static string CreateResponsiveSearchAd(GoogleAdsClient client,
            string adGroupResourceName)
        {
            Ad ad = new Ad()
            {
                ResponsiveSearchAd = new ResponsiveSearchAdInfo()
                {
                    Headlines =
                    {
                        // Sets a pinning to always choose this asset for HEADLINE_1. Pinning is
                        // optional; if no pinning is set, then headlines and descriptions will be
                        // rotated and the ones that perform best will be used more often.
                        new AdTextAsset() {
                            Text = "Cruise to Mars #" + ExampleUtilities.GetShortRandomString(),
                            PinnedField = ServedAssetFieldType.Headline1
                        },
                        new AdTextAsset() { Text = "Best Space Cruise Line" },
                        new AdTextAsset() { Text = "Experience the Stars" },
                    },
                    Descriptions =
                    {
                        new AdTextAsset() { Text = "Buy your tickets now" },
                        new AdTextAsset() { Text = "Visit the Red Planet" },
                    },
                    Path1 = "all-inclusive",
                    Path2 = "deals"
                },
                FinalUrls = { "http://www.example.com" }
            };

            return CreateAdGroupAd(client, ad, adGroupResourceName);
        }

        /// <summary>
        /// Creates the expanded text ad.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="adGroupResourceName">Resource name of the ad group in which expanded
        /// text ad is created.</param>
        /// <returns>The resource name of the newly created expanded text ad.</returns>
        internal static string CreateExpandedTextAd(GoogleAdsClient client,
            string adGroupResourceName)
        {
            Ad ad = new Ad
            {
                FinalUrls = { "http://www.example.com/" },
                ExpandedTextAd = new ExpandedTextAdInfo
                {
                    Description = "Buy your tickets now!",
                    HeadlinePart1 = $"Cruise #{DateTime.Now.Ticks % 1000} to Mars",
                    HeadlinePart2 = "Best Space Cruise Line",
                    Path1 = "path1",
                    Path2 = "path2"
                }
            };

            return CreateAdGroupAd(client, ad, adGroupResourceName);
        }

        /// <summary>
        /// Creates an ad group ad.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="adGroupResourceName">Resource name of the ad group in which the ad
        /// is created.</param>
        /// <param name="ad">The ad to create.</param>
        /// <returns>The resource name of the newly created ad group ad.</returns>
        internal static string CreateAdGroupAd(GoogleAdsClient client, Ad ad,
            string adGroupResourceName)
        {
            AdGroupAd adGroupAd = new AdGroupAd
            {
                AdGroup = adGroupResourceName,
                Status = AdGroupAdStatus.Paused,
                Ad = ad
            };

            MutateOperation mutateOperation = new MutateOperation()
            {
                AdGroupAdOperation = new AdGroupAdOperation() { Create = adGroupAd }
            };
            return ExecuteOperations(client, new[] { mutateOperation }).First()
                .AdGroupAdResult.ResourceName;
        }

        /// <summary>
        /// Creates a keyword.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="adGroupResourceName">The resource name of the ad group to which keyword
        /// is added.</param>
        /// <returns>The resource name of the newly created keyword.</returns>
        internal static string CreateKeyword(GoogleAdsClient client, string adGroupResourceName)
        {
            AdGroupCriterion criterion = new AdGroupCriterion()
            {
                AdGroup = adGroupResourceName,
                Status = AdGroupCriterionStatus.Enabled,
                Keyword = new KeywordInfo()
                {
                    Text = $"mars cruise #{DateTime.Now.Ticks}",
                    MatchType = KeywordMatchType.Exact
                }
            };
            MutateOperation mutateOperation = new MutateOperation()
            {
                AdGroupCriterionOperation = new AdGroupCriterionOperation() { Create = criterion }
            };
            return ExecuteOperations(client, new[] { mutateOperation }).First()
                .AdGroupCriterionResult.ResourceName;
        }

        /// <summary>
        /// Retrieves a campaign's ID.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="campaignResourceName">The resource name of the campaign.</param>
        /// <returns>The campaign ID.</returns>
        internal static long GetCampaign(GoogleAdsClient client, string campaignResourceName)
        {
            string query = $"SELECT campaign.id FROM campaign WHERE " +
                $"campaign.resource_name='{campaignResourceName}' ORDER BY campaign.id";
            return GetGoogleAdsRows(client, query).First().Campaign.Id.Value;
        }

        /// <summary>
        /// Retrieves an ad group's ID.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="adGroupResourceName">The resource name of the ad group.</param>
        /// <returns>The ad group ID.</returns>
        internal static long GetAdGroup(GoogleAdsClient client, string adGroupResourceName)
        {
            string query = $"SELECT ad_group.id FROM ad_group WHERE " +
                $"ad_group.resource_name='{adGroupResourceName}' ORDER BY ad_group.id";
            return GetGoogleAdsRows(client, query).First().AdGroup.Id.Value;
        }

        /// <summary>
        /// Retrieves an adgroup ad's ID
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="adGroupAdResourceName">The resource name of the ad group ad.</param>
        /// <returns>The ad group ID.</returns>
        internal static long GetAdGroupAd(GoogleAdsClient client, string adGroupAdResourceName)
        {
            string query = $"SELECT ad_group_ad.ad.id FROM ad_group_ad WHERE " +
                $"ad_group_ad.resource_name='{adGroupAdResourceName}'";
            return GetGoogleAdsRows(client, query).First().AdGroupAd.Ad.Id.Value;
        }

        /// <summary>
        /// Retrieves an adgroup ad's ID
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="adGroupAdResourceName">The resource name of the ad group.</param>
        /// <returns>The keyword ID.</returns>
        internal static long GetKeyword(GoogleAdsClient client, string adGroupCriterionResourceName)
        {
            string query = $"SELECT ad_group_criterion.criterion_id FROM ad_group_criterion" +
                $" WHERE ad_group_criterion.resource_name = '{adGroupCriterionResourceName}'";
            return GetGoogleAdsRows(client, query).First().AdGroupCriterion.CriterionId.Value;
        }

        /// <summary>
        /// Creates the campaign experiment.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignDraftResourceName">The campaign draft resource name.</param>
        /// <returns>The resource name of the newly created campaign experiment.</returns>
        internal static string CreateCampaignExperiment(GoogleAdsClient client, long customerId,
            string campaignDraftResourceName)
        {
            // Get the CampaignExperimentService.
            CampaignExperimentServiceClient campaignExperimentService =
                client.GetService(Services.V4.CampaignExperimentService);

            CampaignExperiment experiment = new CampaignExperiment()
            {
                CampaignDraft = campaignDraftResourceName,
                Name = "Campaign Experiment - " + ExampleUtilities.GetRandomString(),
                TrafficSplitPercent = 50,
                TrafficSplitType = CampaignExperimentTrafficSplitType.RandomQuery
            };

            Operation<Empty, CreateCampaignExperimentMetadata> operation =
                campaignExperimentService.CreateCampaignExperiment(
                    customerId.ToString(), experiment);

            string experimentResourceName = operation.Metadata.CampaignExperiment;
            operation.PollUntilCompleted();
            return experimentResourceName;
        }

        /// <summary>
        /// Creates the campaign draft.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="baseCampaignId">The base campaign ID.</param>
        /// <returns>The resource name of the newly created campaign draft.</returns>
        internal static string CreateCampaignDraft(GoogleAdsClient client, long customerId,
            long baseCampaignId)
        {
            // Get the CampaignDraftService.
            CampaignDraftServiceClient campaignDraftService =
                client.GetService(Services.V4.CampaignDraftService);

            CampaignDraft campaignDraft = new CampaignDraft()
            {
                BaseCampaign = ResourceNames.Campaign(customerId, baseCampaignId),
                Name = "Campaign Draft #" + ExampleUtilities.GetRandomString(),
            };

            CampaignDraftOperation operation = new CampaignDraftOperation()
            {
                Create = campaignDraft
            };

            MutateCampaignDraftsResponse response = campaignDraftService.MutateCampaignDrafts(
                customerId.ToString(), new CampaignDraftOperation[] { operation });

            return response.Results[0].ResourceName;
        }

        /// <summary>
        /// Gets the campaign experiment.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="experimentResourceName">The experiment resource name.</param>
        /// <returns>ID of the campagin experiment.</returns>
        internal static long GetCampaignExperiment(GoogleAdsClient client, long customerId,
            string experimentResourceName)
        {
            string query = $"SELECT campaign_experiment.experiment_campaign, " +
                $"campaign_experiment.id FROM campaign_experiment WHERE " +
                $"campaign_experiment.resource_name = '{experimentResourceName}'";
            return GetGoogleAdsRows(client, query).First().CampaignExperiment.Id.Value;
        }

        /// <summary>
        /// Execute a list of operations and return results.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="operations">The list of operations.</param>
        /// <returns>The list of mutate responses from executing the operations.</returns>
        internal static IEnumerable<MutateOperationResponse> ExecuteOperations(
            GoogleAdsClient client, MutateOperation[] operations)
        {
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V4.GoogleAdsService);

            MutateGoogleAdsRequest request = new MutateGoogleAdsRequest()
            {
                CustomerId = client.Config.ClientCustomerId.ToString(),
            };
            request.MutateOperations.AddRange(operations);

            return googleAdsService.Mutate(request).MutateOperationResponses;
        }

        /// <summary>
        /// Gets a list of google ads rows.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The list of google ads rows.</returns>
        internal static IEnumerable<GoogleAdsRow> GetGoogleAdsRows(GoogleAdsClient client,
            string query)
        {
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V4.GoogleAdsService);

            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest()
            {
                Query = query,
                CustomerId = client.Config.ClientCustomerId.ToString()
            };

            return googleAdsService.Search(request);
        }
    }
}
