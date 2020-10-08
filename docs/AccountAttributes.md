# IO.Swagger.Model.AccountAttributes
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountName** | **string** | Name of the account | [optional] 
**Username** | **string** | Name of account&#x27;s master user | [optional] 
**MaxUsers** | **int?** | Maximum number of users the account can have. This can be increased by contacting ExaVault Support. | [optional] 
**UserCount** | **int?** | Current number of users on the account. | [optional] 
**Status** | **int?** | Account status flag. A one (1) means the account is active; zero (0) means it is suspended. | [optional] 
**Branding** | **bool?** | Branding flag. Set to &#x60;true&#x60; if the account has branding functionality enabled. | [optional] 
**CustomDomain** | **bool?** | Custom domain flag. Set to &#x60;true&#x60; if account type allows custom domain functionality. | [optional] 
**Quota** | [**Quota**](Quota.md) |  | [optional] 
**SecureOnly** | **bool?** | Flag to indicate whether the account disables connections via insecure protocols (e.g. FTP). Set to &#x60;true&#x60; to disable all traffic over port 21. | [optional] 
**ComplexPasswords** | **bool?** | Flag to indicate whether the account requires complex passwords. Set to &#x60;true&#x60; to require complex passwords on all users and shares. | [optional] 
**ShowReferralLinks** | **bool?** | Flag to indicate showing of referrals links in the account. Set to &#x60;true&#x60; to include marketing messages in share invitations. | [optional] 
**ExternalDomains** | **List&lt;string&gt;** | Custom domain used to brand this account. | [optional] 
**AllowedIp** | [**List&lt;AccountAttributesAllowedIp&gt;**](AccountAttributesAllowedIp.md) | Range of IP addresses allowed to access this account. | [optional] 
**CallbackSettings** | [**CallbackSettings**](CallbackSettings.md) |  | [optional] 
**BrandingSettings** | [**BrandingSettings**](BrandingSettings.md) |  | [optional] 
**ClientId** | **int?** | (ExaVault Use Only) Internal ID of the account in CMS. | [optional] 
**WelcomeEmailContent** | **string** | Content of welcome email each new user will receive. | [optional] 
**WelcomeEmailSubject** | **string** | Subject of welcome email each new user will receive. | [optional] 
**CustomSignature** | **string** | Custom signature for all account emails users or recipients will receive. | [optional] 
**AccountOnboarding** | **bool?** | Whether the web application onboarding help is enabled for new users in the account. | [optional] 
**Created** | **DateTime?** | Timestamp of account creation. | [optional] 
**Modified** | **DateTime?** | Timestamp of account modification. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

