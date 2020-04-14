![](https://github.com/Microsoft/MCW-Template-Cloud-Workshop/raw/master/Media/ms-cloud-workshop.png "Microsoft Cloud Workshops")

<div class="MCWHeader1">
App modernization
</div>

<div class="MCWHeader2">
Hands-on lab unguided
</div>

<div class="MCWHeader3">
August 2018
</div>

Information in this document, including URL and other Internet Web site references, is subject to change without notice. Unless otherwise noted, the example companies, organizations, products, domain names, e-mail addresses, logos, people, places, and events depicted herein are fictitious, and no association with any real company, organization, product, domain name, e-mail address, logo, person, place or event is intended or should be inferred. Complying with all applicable copyright laws is the responsibility of the user. Without limiting the rights under copyright, no part of this document may be reproduced, stored in or introduced into a retrieval system, or transmitted in any form or by any means (electronic, mechanical, photocopying, recording, or otherwise), or for any purpose, without the express written permission of Microsoft Corporation.

Microsoft may have patents, patent applications, trademarks, copyrights, or other intellectual property rights covering subject matter in this document. Except as expressly provided in any written license agreement from Microsoft, the furnishing of this document does not give you any license to these patents, trademarks, copyrights, or other intellectual property.

The names of manufacturers, products, or URLs are provided for informational purposes only and Microsoft makes no representations and warranties, either expressed, implied, or statutory, regarding these manufacturers or the use of the products with any Microsoft technologies. The inclusion of a manufacturer or product does not imply endorsement of Microsoft of the manufacturer or product. Links may be provided to third party sites. Such sites are not under the control of Microsoft and Microsoft is not responsible for the contents of any linked site or any link contained in a linked site, or any changes or updates to such sites. Microsoft is not responsible for webcasting or any other form of transmission received from any linked site. Microsoft is providing these links to you only as a convenience, and the inclusion of any link does not imply endorsement of Microsoft of the site or the products contained therein.

©  2018 Microsoft Corporation. All rights reserved.

Microsoft and the trademarks listed at <https://www.microsoft.com/en-us/legal/intellectualproperty/Trademarks/Usage/General.aspx> are trademarks of the Microsoft group of companies. All other trademarks are property of their respective owners.

**Contents**

<!-- TOC -->

- [App modernization hands-on lab unguided](#app-modernization-hands-on-lab-unguided)
    - [Abstract and learning objectives](#abstract-and-learning-objectives)
    - [Overview](#overview)
    - [Solution architecture](#solution-architecture)
    - [Requirements](#requirements)
    - [Exercise 1: Migrate the database to Azure SQL Database](#exercise-1-migrate-the-database-to-azure-sql-database)
        - [Task 1: Provision a SQL Server](#task-1-provision-a-sql-server)
            - [Tasks to complete](#tasks-to-complete)
            - [Exit criteria](#exit-criteria)
        - [Task 2: Configure SQL Server firewall](#task-2-configure-sql-server-firewall)
            - [Tasks to complete](#tasks-to-complete-1)
            - [Exit criteria](#exit-criteria-1)
        - [Task 3: Migrate the on-premises SQL database to Azure](#task-3-migrate-the-on-premises-sql-database-to-azure)
            - [Tasks to complete](#tasks-to-complete-2)
            - [Exit criteria](#exit-criteria-2)
    - [Exercise 2: Provision App Services](#exercise-2-provision-app-services)
        - [Task 1: Create a Web App](#task-1-create-a-web-app)
            - [Tasks to complete](#tasks-to-complete-3)
            - [Exit criteria](#exit-criteria-3)
        - [Task 1: Provision an API App](#task-1-provision-an-api-app)
            - [Tasks to complete](#tasks-to-complete-4)
            - [Exit criteria](#exit-criteria-4)
    - [Exercise 3: Identity and security](#exercise-3-identity-and-security)
        - [Task 1: Create a new Contoso user](#task-1-create-a-new-contoso-user)
            - [Tasks to complete](#tasks-to-complete-5)
            - [Exit criteria](#exit-criteria-5)
        - [Task 2: Register the Web API application](#task-2-register-the-web-api-application)
            - [Tasks to complete](#tasks-to-complete-6)
            - [Exit criteria](#exit-criteria-6)
        - [Task 3: Expose Web API to other applications](#task-3-expose-web-api-to-other-applications)
            - [Tasks to complete](#tasks-to-complete-7)
            - [Exit criteria](#exit-criteria-7)
        - [Task 4: Register the Desktop (WinForms) application](#task-4-register-the-desktop-winforms-application)
            - [Tasks to complete](#tasks-to-complete-8)
            - [Exit criteria](#exit-criteria-8)
        - [Task 5: Register the mobile application](#task-5-register-the-mobile-application)
            - [Tasks to complete](#tasks-to-complete-9)
            - [Exit criteria](#exit-criteria-9)
        - [Task 6: Configure access control for the PolicyConnect web application](#task-6-configure-access-control-for-the-policyconnect-web-application)
            - [Tasks to complete](#tasks-to-complete-10)
            - [Exit criteria](#exit-criteria-10)
        - [Task 7: Grant the ContosoInsurance Web app permissions to the Web API app](#task-7-grant-the-contosoinsurance-web-app-permissions-to-the-web-api-app)
            - [Tasks to complete](#tasks-to-complete-11)
            - [Exit criteria](#exit-criteria-11)
    - [Exercise 4: Upload PDFs to Blob storage](#exercise-4-upload-pdfs-to-blob-storage)
        - [Task 1: Provision a storage account](#task-1-provision-a-storage-account)
            - [Tasks to complete](#tasks-to-complete-12)
            - [Exit criteria](#exit-criteria-12)
        - [Task 2: Create container for storing PDFs in Azure storage](#task-2-create-container-for-storing-pdfs-in-azure-storage)
            - [Tasks to complete](#tasks-to-complete-13)
            - [Exit criteria](#exit-criteria-13)
        - [Task 3: Bulk upload PDFs to blob storage using AzCopy](#task-3-bulk-upload-pdfs-to-blob-storage-using-azcopy)
            - [Tasks to complete](#tasks-to-complete-14)
            - [Exit criteria](#exit-criteria-14)
    - [Exercise 5: Create serverless API for accessing PDFs](#exercise-5-create-serverless-api-for-accessing-pdfs)
        - [Task 1: Provision a Function App](#task-1-provision-a-function-app)
            - [Tasks to complete](#tasks-to-complete-15)
            - [Exit criteria](#exit-criteria-15)
        - [Task 2: Retrieve URL for policy documents in Azure stoage](#task-2-retrieve-url-for-policy-documents-in-azure-stoage)
            - [Tasks to complete](#tasks-to-complete-16)
            - [Exit criteria](#exit-criteria-16)
        - [Task 3: Create an Azure Functions Proxy](#task-3-create-an-azure-functions-proxy)
            - [Tasks to complete](#tasks-to-complete-17)
            - [Exit criteria](#exit-criteria-17)
        - [Task 4: Parameterize Azure Functions Proxy](#task-4-parameterize-azure-functions-proxy)
            - [Tasks to complete](#tasks-to-complete-18)
            - [Exit criteria](#exit-criteria-18)
    - [Exercise 6: Create an Azure Search service](#exercise-6-create-an-azure-search-service)
        - [Task 1: Create an Azure search service](#task-1-create-an-azure-search-service)
            - [Tasks to complete](#tasks-to-complete-19)
            - [Exit criteria](#exit-criteria-19)
        - [Task 2: Configure full-text search indexing](#task-2-configure-full-text-search-indexing)
            - [Tasks to complete](#tasks-to-complete-20)
            - [Exit criteria](#exit-criteria-20)
    - [Exercise 7: Configure Key Vault](#exercise-7-configure-key-vault)
        - [Task 1: Create a new Key Vault](#task-1-create-a-new-key-vault)
            - [Tasks to complete](#tasks-to-complete-21)
            - [Exit criteria](#exit-criteria-21)
        - [Task 2: Create a new secret to store the SQL connection string](#task-2-create-a-new-secret-to-store-the-sql-connection-string)
            - [Tasks to complete](#tasks-to-complete-22)
            - [Exit criteria](#exit-criteria-22)
        - [Task 3: Grant access to the secret to the Web API application](#task-3-grant-access-to-the-secret-to-the-web-api-application)
            - [Tasks to complete](#tasks-to-complete-23)
            - [Exit criteria](#exit-criteria-23)
    - [Exercise 8: Configure and deploy the Contoso Insurance Web API](#exercise-8-configure-and-deploy-the-contoso-insurance-web-api)
        - [Task 1: Add Application Settings to the API App](#task-1-add-application-settings-to-the-api-app)
            - [Tasks to complete](#tasks-to-complete-24)
            - [Exit criteria](#exit-criteria-24)
        - [Task 2: Deploy the Web API app from Visual Studio](#task-2-deploy-the-web-api-app-from-visual-studio)
            - [Tasks to complete](#tasks-to-complete-25)
            - [Exit criteria](#exit-criteria-25)
        - [Task 3: Verify the Web API deployment](#task-3-verify-the-web-api-deployment)
            - [Tasks to complete](#tasks-to-complete-26)
            - [Exit criteria](#exit-criteria-26)
    - [Exercise 9: Configure and deploy the Contoso Insurance web app](#exercise-9-configure-and-deploy-the-contoso-insurance-web-app)
        - [Task 1: Configure application settings in Azure](#task-1-configure-application-settings-in-azure)
            - [Tasks to complete](#tasks-to-complete-27)
            - [Exit criteria](#exit-criteria-27)
        - [Task 2: Deploy the Contoso Insurance Web App from Visual Studio](#task-2-deploy-the-contoso-insurance-web-app-from-visual-studio)
            - [Tasks to complete](#tasks-to-complete-28)
            - [Exit criteria](#exit-criteria-28)
        - [Task 3: Login and verify the Web App deployment](#task-3-login-and-verify-the-web-app-deployment)
            - [Tasks to complete](#tasks-to-complete-29)
            - [Exit criteria](#exit-criteria-29)
    - [Exercise 10: Configure and run the legacy desktop (Windows Forms) application](#exercise-10-configure-and-run-the-legacy-desktop-windows-forms-application)
        - [Task 1: Configure application settings in App.config](#task-1-configure-application-settings-in-appconfig)
            - [Tasks to complete](#tasks-to-complete-30)
            - [Exit criteria](#exit-criteria-30)
        - [Task 2: Run the desktop application](#task-2-run-the-desktop-application)
            - [Tasks to complete](#tasks-to-complete-31)
            - [Exit criteria](#exit-criteria-31)
    - [Exercise 11: Configure and run the mobile application](#exercise-11-configure-and-run-the-mobile-application)
        - [Task 1: Configure application settings in ApplicationSettings.cs](#task-1-configure-application-settings-in-applicationsettingscs)
            - [Tasks to complete](#tasks-to-complete-32)
            - [Exit criteria](#exit-criteria-32)
        - [Task 2: Run the mobile application](#task-2-run-the-mobile-application)
            - [Task to complete](#task-to-complete)
            - [Exit criteria](#exit-criteria-33)
    - [Exercise 12: Create a Flow app that sends push notifications](#exercise-12-create-a-flow-app-that-sends-push-notifications)
        - [Task 1: Sign up for a Flow account](#task-1-sign-up-for-a-flow-account)
            - [Tasks to complete](#tasks-to-complete-33)
            - [Exit criteria](#exit-criteria-34)
        - [Task 2: Create new flow](#task-2-create-new-flow)
            - [Tasks to complete](#tasks-to-complete-34)
            - [Exit criteria](#exit-criteria-35)
        - [Task 3: Test your flow](#task-3-test-your-flow)
            - [Tasks to complete](#tasks-to-complete-35)
            - [Exit criteria](#exit-criteria-36)
    - [Exercise 13: Create an app in PowerApps](#exercise-13-create-an-app-in-powerapps)
        - [Task 1: Sign up for a PowerApps account](#task-1-sign-up-for-a-powerapps-account)
            - [Tasks to complete](#tasks-to-complete-36)
            - [Exit criteria](#exit-criteria-37)
        - [Task 2: Create a new SQL connection](#task-2-create-a-new-sql-connection)
            - [Tasks to complete](#tasks-to-complete-37)
            - [Exit criteria](#exit-criteria-38)
        - [Task 3: Create a new app](#task-3-create-a-new-app)
            - [Tasks to complete](#tasks-to-complete-38)
            - [Exit criteria](#exit-criteria-39)
        - [Task 4: Design app](#task-4-design-app)
            - [Tasks to complete](#tasks-to-complete-39)
            - [Exit criteria](#exit-criteria-40)
        - [Task 5: Edit the app settings and run the app](#task-5-edit-the-app-settings-and-run-the-app)
            - [Tasks to complete](#tasks-to-complete-40)
            - [Exit criteria](#exit-criteria-41)
    - [Exercise 14: Add Azure Function to Azure API Management](#exercise-14-add-azure-function-to-azure-api-management)
        - [Task 1: Provision Azure API Management](#task-1-provision-azure-api-management)
            - [Tasks to complete](#tasks-to-complete-41)
            - [Exit criteria](#exit-criteria-42)
        - [Task 2: Add API Definition to Function App](#task-2-add-api-definition-to-function-app)
            - [Tasks to complete](#tasks-to-complete-42)
            - [Exit criteria](#exit-criteria-43)
        - [Task 3: Import the Funtion App to API Management(APIM)](#task-3-import-the-funtion-app-to-api-managementapim)
            - [Tasks to complete](#tasks-to-complete-43)
            - [Exit criteria](#exit-criteria-44)
        - [Task 4: Test the APIM Developer Portal](#task-4-test-the-apim-developer-portal)
            - [Tasks to complete](#tasks-to-complete-44)
            - [Exit criteria](#exit-criteria-45)
    - [After the hands-on lab](#after-the-hands-on-lab)
        - [Task 1: Delete the Resource group in which you placed your Azure resources.](#task-1-delete-the-resource-group-in-which-you-placed-your-azure-resources)
        - [Task 2: Delete the Azure Active Directory app registrations for Desktop and Mobile](#task-2-delete-the-azure-active-directory-app-registrations-for-desktop-and-mobile)
        - [Task 3: Delete Flow](#task-3-delete-flow)
    - [Appendix A: Create a self-signed certificate](#appendix-a-create-a-self-signed-certificate)
        - [Task 1: Create self-signed certificate](#task-1-create-self-signed-certificate)
        - [Task 2: Create and install your temporary service certificate](#task-2-create-and-install-your-temporary-service-certificate)
        - [Task 3: Configure the IIS Express self-signed certificate](#task-3-configure-the-iis-express-self-signed-certificate)

<!-- /TOC -->

# App modernization hands-on lab unguided

## Abstract and learning objectives

In this hands-on lab, you will implement the steps to modernize legacy on-premises applications and infrastructure by leveraging cloud services, while adding a mix of web and mobile services, all secured using Azure Active Directory.

At the end of this hands-on lab, you will be better able to build solutions for modernizing legacy on-premises applications and infrastructure using cloud services, and implement a mix of web and mobile services secured by Azure Active Directory.

## Overview

The App Modernization hands-on lab is an exercise that will challenge you to implement an end-to-end scenario using a supplied sample that is based on Microsoft Azure App Services and related services. The scenario will include implementing compute, storage, security, and search, using various components of Microsoft Azure. The hands-on lab can be implemented on your own, but it is highly recommended to pair up with other members at the lab to model a real-world experience and to allow each member to share their expertise for the overall solution.

## Solution architecture

After lawyers affirmed that Contoso, Ltd. could legally store customer data in the cloud, Contoso created a strategy that capitalized on the capabilities of Microsoft Azure. Below is a diagram of the solution architecture you will build in the lab. Please study this carefully, so you understand the whole of the solution as you are working on the various components.

![Architecture diagram of the preferred solution. Mobile and web apps connect APIs and Azure Functions Proxies, secured by Azure AD, with application secrets stored in Key Vault. Redis Cache is used to improve application performance, and data is stored in SQL Server and Azure Blob Storage. PowerApps and Flow are used to enable business users to build mobile and web (CRUD) applications. Azure API Management is used to provide an API Store experience for developers.](media/unguided-image2.png "Solution architecture")

The solution begins with mobile apps (built for Android and iOS using **Xamarin**) and a website, both of which provide access to PolicyConnect. The website, hosted in a **Web App**, provides the user interface for browser-based clients, whereas the Xamarin Forms-based apps provide the UI to mobile devices. Both mobile app and website rely on web services hosted in an **API App**. In addition to the API App, a lightweight, serverless API is provided by **Azure Functions Proxies** to provide access to policy documents stored in **Blob Storage**. **Azure API Management** is used as a proof of concept for the future goal to create a API Store for development teams and affiliated partners. Sensitive configuration data, like connection strings, are stored in **Key Vault** and accessed from the API App or Web App on demand so that these settings never live in their file system. Full-text search of policy documents is enabled by the Indexer for **Blob Storage** (which indexes text in the Word and PDF documents) and stores the results in an **Azure Search** index. **PowerApps** enable authorized business users to build mobile and web create, read, update, delete (CRUD) applications that interact with **SQL Database** and Azure Storage, while **Microsoft Flow** enables orchestrations between services such as Office 365 email and services for sending mobile notifications. These orchestrations can be used independently of PowerApps or invoked by PowerApps to provide additional logic. The solution uses user and application identities maintained in **Azure AD**.

## Requirements

-   Microsoft Azure subscription (non-Microsoft subscription).

-   **Global Administrator role** for Azure AD within your subscription.

-   Local machine or a virtual machine configured with (**complete the day before the lab!**):

    -   Visual Studio Community 2017 or greater

    -   Visual Studio 2017 workloads for:

        -   Azure development

        -   Mobile development with .NET

    -   SQL Server 2017 Express or greater

    -   SQL Server Management Studio (SSMS)

    -   PowerShell 1.1.0 or higher


## Exercise 1: Migrate the database to Azure SQL Database

Duration: 15 minutes

Contoso Insurance has asked you to migrate their on-premises SQL database to Azure SQL Database. In this exercise, you will provision a new SQL Server in Azure, configure the firewall for that SQL Server, and then use SSMS to migrate the Contoso Insurance database from on-premises to Azure SQL Database.

### Task 1: Provision a SQL Server

In this task, you will create a SQL Server (logical server). You will not create the databases at this time since it will be created during the database migration step.

#### Tasks to complete

-   Provision a SQL Server (logical server) in Azure.

#### Exit criteria 

-   You have a SQL Server provisioned in Azure.

### Task 2: Configure SQL Server firewall

In this task, you will create a firewall rule to allow access to your SQL Server.

#### Tasks to complete

-   Create a firewall rule to allow all IP addresses to access the SQL Server.

#### Exit criteria 

-   Your firewall rule is active.

-   You can access your SQL Server from your (or your Lab VM's) IP address.

### Task 3: Migrate the on-premises SQL database to Azure

In this task, you will migrate the Contoso Insurance database from on-premises (Lab VM) into Azure SQL Database.

#### Tasks to complete

-   Use SSMS to deploy the Contoso Insurance database to Microsoft Azure SQL Database.

#### Exit criteria 

-   You are able to access the database and tables in Azure SQL Database via SSMS.

## Exercise 2: Provision App Services

Duration: 15 minutes

Contoso Insurance has asked you to provision resources in Azure for hosting their web and API applications. In this exercise you will create a Web App and an API App in Azure.

### Task 1: Create a Web App

In this task, you will provision a Web App and API App for hosting the Contoso Insurance applications in Azure.

#### Tasks to complete

-   Provision a Web App in Azure.

#### Exit criteria 

-   You are able to navigate to the landing page for your Web App in a browser.

### Task 1: Provision an API App

#### Tasks to complete

-   Provision an API App in Azure.

#### Exit criteria 

-   You have an API App provisioned in Azure.

## Exercise 3: Identity and security

Duration: 45 minutes

Azure Active Directory (Azure AD) will be used to allow users to authenticate to the web app, PolicyConnect desktop app, mobile apps, and PowerApps solutions. Azure AD will also be used to manage application access to Key Vault secrets. You have been asked to create a new Azure AD Tenant and secure the application so only users from the tenant can log on.

>**Note**: Tasks 1 and 2 require global admin permissions on the Azure AD Tenant. Task 3 requires the permission to create an app in the Azure AD tenant. Task 1 and 2 cannot be completed if you use Microsoft Azure AD tenant.

### Task 1: Create a new Contoso user

In this task, you will create an Azure AD user account that will be used for authenticating against the web and mobile apps.

>**Note**: This task is valid only if you are a global administrator on the Azure AD tenant associated with your subscription.

#### Tasks to complete

-   Create a new Contoso user named **Contoso User** in your Azure AD tenant and retrieve the temporary password auto-generated by Azure AD for later reference.

#### Exit criteria

-   You have made note of the full username for later use. The username will be in the following format: contosouser@\[your tenant\].onmicrosoft.com.

-   You have saved the temporary password for later.

### Task 2: Register the Web API application

#### Tasks to complete

-   Add the Web API application to your AAD tenant.

-   Set the sign-on URL: http://\<your web api name\>.azurewebsites.net.

-   Create a new key named webapikey, then copy the generated value for later reference.

-   Add a new Reply URL, making it the same as the other one, but using https.

#### Exit criteria

-   You have saved the new key value for later.

-   You have copied and saved the Reply URLs for later.

-   You have copied and saved the Application ID and App ID URI values for later.

### Task 3: Expose Web API to other applications 

To make the Web API accessible to other applications added to Azure AD, you must define the appropriate permissions. You will modify the manifest for the Web API to configure these settings, since, as of now, the Azure portal does not provide an interface for this.

#### Tasks to complete

-   Expose the Web API to other applications by updating the manifest to enable **oauth2AllowImplicitFlow** and adding an **oauth2Permissions** entry that allows applications to read-write the Contoso Web API on behalf of the signed-in user.

#### Exit criteria

-   Your Web API manifest has been updated to enable oauth2AllowImplicitFlow.

-   You have an oauth2Permissions entry with the following information (replace the id value with a new GUID):

    ```
    {
        "adminConsentDescription": "Allow read-write access to the Contoso Insurance Web API on behalf of the signed-in user",
        "adminConsentDisplayName": "Read-Write access to Contoso Insurance Web API",
        "id": "494581dd-4bf5-451d-9bf8-487f4a43a09c",
        "isEnabled": true,
        "type": "User",
        "userConsentDescription": "Allow read-write access to the Contoso Insurance Web API on your behalf",
        "userConsentDisplayName": "Read-Write access to Contoso Insurance Web API",
        "value": "Read_Write_ContosoInsurance_WebAPI"
    }

    ```

### Task 4: Register the Desktop (WinForms) application 

#### Tasks to complete

-   Add the Contoso Insurance Desktop app to your AAD tenant and grant permissions to the Web API application.

#### Exit criteria

-   You have copied the Redirect URI for later.

-   The "Read-write access to Contoso Insurance Web API" permission that you added through the manifest has been selected when adding API access to the app's required permissions.

-   You have copied the Application ID for later.

### Task 5: Register the mobile application 

#### Tasks to complete

-   Add the Contoso Insurance mobile app to your AAD tenant and grant permissions to the Web API application.

#### Exit criteria

-   You have copied the Redirect URI for later.

-   The "Read-write access to Contoso Insurance Web API" permission that you added through the manifest has been selected when adding API access to the app's required permissions.

-   You have copied the Application ID for later.

### Task 6: Configure access control for the PolicyConnect web application

#### Tasks to complete

-   Modify the PolicyConnect website authentication settings to use AAD.

#### Exit criteria

-   The Azure Active Directory authentication provider has been added to the web application, using Express management mode.

### Task 7: Grant the ContosoInsurance Web app permissions to the Web API app 

#### Tasks to complete

-   Grant permissions for the website to the Web API within AAD and update the manifest to enable **oauth2AllowImplicitFlow**.

#### Exit criteria

-   You have added two new Reply URIs and copied their values for later:

    -   Enter "https://\<your web app name\>.azurewebsites.net/".

    -   Enter "https://\<your web app name\>.azurewebsites.net/static".

-   The "Read-write access to Contoso Insurance Web API" permission that you added through the manifest has been selected when adding API access to the app's required permissions.

-   You have copied the Application ID for later.

## Exercise 4: Upload PDFs to Blob storage

Duration: 15 minutes

Contoso Insurance is currently storing all of their scanned PDF documents on a local network share. They have asked to be able to store them in the cloud automatically from a workflow. In this exercise, you will provision a storage account that will be used to store the files in a blob container. Then, you will provide a way to bulk upload their existing PDFs.

### Task 1: Provision a storage account

#### Tasks to complete

-   Create a storage account in the Azure portal, preferably in the same region as your other resources.

-   Copy the key1 access key.

#### Exit criteria

-   You have a storage account.

-   You have saved the storage account key for later use.

### Task 2: Create container for storing PDFs in Azure storage

In this task, you will create a new container in your storage account for the scanned PDF policy documents.

#### Tasks to complete

-   Create a blob storage container in your storage account named "policies".

-   Copy the container URL.

#### Exit criteria

-   You have a policies container in your storage account.

-   You have saved the container URL for later reference.

### Task 3: Bulk upload PDFs to blob storage using AzCopy

In this task, you will download and install [AzCopy](https://docs.microsoft.com/en-us/azure/storage/common/storage-use-azcopy). You will then use AzCopy to copy the PDF files from the "on-premises" location into the policies container in Azure storage.

#### Tasks to complete

-   Download and install AzCopy from <http://aka.ms/downloadazcopy>.

-   Using AzCopy, copy the files from your on-premises location into the policies container of your storage account in Azure.

#### Exit criteria

-   The PDF policy documents are accessible in your storage account's policies container.

## Exercise 5: Create serverless API for accessing PDFs

Duration: 15 minutes

Contoso Insurance has made some updates to prepare their applications, but there are some features that they have not been able to build into the API yet. They have requested that you assist them in setting up a proof-of-concept (POC) API solution to enable users of their application to retrieve their policy documents directly from their Azure Storage account. In this exercise, you will create a Function App, and an Azure Functions Proxy to enable this functionality using serverless technologies.

### Task 1: Provision a Function App

#### Tasks to complete

-   Create a Function App in the Azure portal.

#### Exit criteria

-   You have a Function App in Azure.

### Task 2: Retrieve URL for policy documents in Azure stoage

In this task, you will retrieve the URL associated with the PDF policy documents you uploaded into Azure storage in the previous exercise.

#### Tasks to complete

-   Retrieve the URL for a single PDF document in your storage account.

-   Copy the URL.

#### Exit criteria

-   You have saved the document's URL for later use.

### Task 3: Create an Azure Functions Proxy

In this task, you will create an Azure Function Proxy, which is a simple way to provide a clean API endpoint. To learn more, check out [Working with Azure Functions Proxies](https://docs.microsoft.com/en-us/azure/azure-functions/functions-proxies).

#### Tasks to complete

-   In your Function App, create a new Proxy named PolicyDocs that allows GET HTTP requests to the URL of the policy document you copied in the previous task.

#### Exit criteria

-   You can navigate to the Proxy URL and download the policy document.

### Task 4: Parameterize Azure Functions Proxy

In the previous task, you created an Azure Functions Proxy to download a specific policy document from Azure storage. In this task, you will update the Proxy to parameterize the URL, so you can retrieve any policy document using the policy holder's last name and their policy number.

#### Tasks to complete

-   Modify your Azure Functions Proxy to provide the following named parameters in the route template:

    -   policyHolder

    -   policyNumber

-   Update the Backend URL to use the parameters.

#### Exit criteria

-   You are able to pass parameters into the Proxy URL, allowing you to access any policy documents in the storage account.

-   You have saved the Proxy URL for later reference.

## Exercise 6: Create an Azure Search service

Duration: 15 minutes

Contoso Insurance has asked for full-text search in the documents. In this exercise, you will provision an Azure Search service, then configure search indexing on the policies blob storage container.

### Task 1: Create an Azure search service

#### Tasks to complete

-   Provision a new search service, making sure to add it to your hands-on lab resource group. Select the Basic tier when provisioning.

#### Exit criteria

-   You have a Search service in Azure.

### Task 2: Configure full-text search indexing

#### Tasks to complete

-   Use the import data feature of the newly provisioned search service to connect to your blob storage container (policies), which contain the PDF files.

-   Name the new index **policies**, using the detected metadata\_storage\_path as the key.

-   Make most of the fields retrievable, and the **content** field both filterable and searchable.

-   Create an indexer for the new index that has a 5-minute interval (for testing only).

-   Configure CORS to allow all origins.

#### Exit criteria

-   All 650 PDFs should be indexed.

-   Use the Search explorer to validate functionality. You should be able to search by full policy number, or partial file content matches.

## Exercise 7: Configure Key Vault

Duration: 15 minutes

Key Vault will be used to protect sensitive information, such as database connection strings and storage account keys. The application services that you have registered within Azure Active Directory will be granted access to the Key Vault secrets you create in this section. You will use secrets instead of keys, due to the small size of the strings being stored, as well as how often you need to retrieve the values. Retrieving secrets from Key Vault is a lower latency operation than retrieving keys, due to the real-time encryption and decryption involved.

### Task 1: Create a new Key Vault

#### Tasks to complete

-   Use the Azure portal to create the Key Vault within your hands-on lab resource group.

-   Make note of the Vault URI for later reference.

#### Exit criteria

-   You are able to navigate to your Key Vault in the Azure portal.

-   You have saved the Key Vault URI for later reference.

### Task 2: Create a new secret to store the SQL connection string

#### Tasks to complete

-   Save the full (including username and password) SQL connection string as a new secret named SQLConnectionString.

-   Obtain the URI to the secret for later reference.

-   Use the Set-AzureRmKeyVaultAccessPolicy cmdlet to grant the Web API application Get access to the secret.

#### Exit criteria

-   You have saved the Secret Identifier URL for later reference.

### Task 3: Grant access to the secret to the Web API application 

In this task you will add the required permissions to allow the Web API application to read the SqlConnectionString secret from your Key Vault.

#### Tasks to complete

-   Set an Access policy to your Key vault to allow the Contoso Insurance Web API to access the SqlConnectionString secret.

#### Exit criteria

-   You are able to read the SqlConnectionString secret from the Web API.

## Exercise 8: Configure and deploy the Contoso Insurance Web API

Duration: 10 minutes

The developers at Contoso Insurance have been working toward migrating their apps to the cloud. As such, most of the pieces are already in place to deploy the apps to Azure, as well as configure them to communicate with the new app services, such as Web API. Since the required services have already been provisioned, what remains is applying application-level configuration settings and then deploying any hosted apps and services from the Visual Studio starter project solution. In this task, you will apply application settings to the Web API using the Azure Portal. Once the application settings have been set, you will then deploy the Web API from the Visual Studio.

### Task 1: Add Application Settings to the API App

In this task, you will add the application settings to the API App for the Web API in the Azure portal.

#### Tasks to complete

-   Apply application settings using the Microsoft Azure Portal:

    -   ClientId

        -   **Key**: ClientId

        -   **Value**: \<Azure AD Application ID for the Web API\>

    -   ClientSecret

        -   **Key**: ClientSecret

        -   **Value**: \<Azure AD Web API Key\>

        -   The ClientSecret value is the Key you created and copied in [Exercise 3, Step 2](#_Task_2:_Register).

    -   SecretUri

        -   **Key**: SecretUri

        -   **Value**: \<Key Vault Secret Identifier for the SqlConnectionString secret\>

        -   The SecretUri value is the Secret Identifier value you copied for the SqlConnectionString secret in Key Vault.

        -   You can omit the version number in this value.

    -   ida:Tenant

        -   **Key**: ida:Tenant

        -   **Value**: \<Azure AD tenant name\>

        -   The ida:Tenant value is your Azure AD tenant name (e.g. contoso.onmicrosoft.com), which can be found by selecting Custom Domain Names within Azure AD in the portal.

    -   ida:Audience

        -   **Key**: ida:Audience

        -   **Value**: \<App ID URI within Azure AD application settings\>

        -   The ida:Audience value is the App ID URI from the Azure portal within the AAD application settings for this Web API.

#### Exit criteria

-   The Web API application settings have been saved in the Azure portal.

### Task 2: Deploy the Web API app from Visual Studio

In this task, you will use Visual Studio to deploy the Web API to your API App in Azure.

#### Tasks to complete

-   Publish the Web API to Azure from the **Contoso.Apps.Insurance.WebAPI** Starter Project in Visual Studio.

#### Exit criteria

-   You are able to hit the landing page for your Web API URL in a web browser.

### Task 3: Verify the Web API deployment

#### Tasks to complete

-   Navigate to the Swagger UI page for your API by typing in /swagger to the end of its URL in your browser (e.g. http://contosoinsurancewebapi.azurewebsites.net/swagger).

#### Exit criteria

-   You should see a list of the available REST APIs. However, you will not be able to execute them from here as they are protected by AAD application permissions, which accept only token-based calls from registered apps.

    ![The Swagger page for the published Web API is displayed.](media/unguided-image40.png "Swagger")

## Exercise 9: Configure and deploy the Contoso Insurance web app

Duration: 10 minutes

In this exercise, you will apply application settings using the Microsoft Azure Portal. You will also edit a .js file in Visual Studio and deploy the Web app from the starter project.

### Task 1: Configure application settings in Azure

#### Tasks to complete

-   Apply application settings using the Azure portal.

    -   RootWebApiPath

        -   **Key**: RootWebApiPath

        -   **Value**: \<URL of your published Web API\>

        -   The RootWebApiPath value is the URL of your published Web API.

        -   **Note**: It is important to make sure this link starts with **https** to ensure proper communication between the web app and the API. Otherwise, the requests to the API may be blocked.

    -   Tenant

        -   **Key**: Tenant

        -   **Value**: \<Azure AD tenant name\>

        -   The Tenant value is your Azure AD tenant name (e.g. contoso.onmicrosoft.com), which can be found by selecting Custom Domain Names within Azure AD in the portal.

    -   WebClientId

        -   **Key**: WebClientId

        -   **Value**: \<Azure AD Application ID\>

        -   The WebClientId value is the Application ID from the Azure AD properties, which you pasted into the text editor for the Web App.

    -   SecretUri

        -   **Key**: WebApiAppId

        -   **Value**: \<Azure AD App URI ID\>

        -   The WebApiAppId value is the App URI ID from Azure AD for your Web API (this is the same value you used for the ida:Audience setting in the Web API application settings).

    -   AzureFunctionsProxyUrl

        -   **Key**: AzureFunctionsProxyUrl

        -   **Value**: \<Proxy URL for your PolicyDocs Azure Functions Proxy\>

        -   The AzureFunctionsProxyUrl value is the Proxy URL associated with the PolicyDocs proxy you created previously (e.g., [https://contosoinsurancedocs.azurewebsites.net/{policyHolder}/{policyNumber}](https://contosoinsurancedocs.azurewebsites.net/%7bpolicyHolder%7d/%7bpolicyNumber%7d)).

-   Modify the **app.js file** in the Scripts \> app folder the file where you see the line (126) that begins with **var endpoints = {**. Change the URL in quotes to the same URL you entered for the RootWebApiPath application variable, which is the root location of your Web API, (e.g. https://contosoinsurancewebapi.azurewebsites.net).

#### Exit criteria

-   Your web app's application settings are saved in the Azure portal.

-   The app.js file's endpoints variable contains the URL to your deployed Web API.

### Task 2: Deploy the Contoso Insurance Web App from Visual Studio

#### Tasks to complete

-   Deploy the web app from the **Contoso.Apps.Insurance.Web** Starter Project in Visual Studio.

#### Exit criteria

-   Validate the website by browsing to it, if it did not automatically launch after publishing.

### Task 3: Login and verify the Web App deployment

#### Tasks to complete

-   Login into the Web app using the [contosouser@\<YOUR-TENANT\>.onmicrosoft.com](mailto:contosouser@%3cYOUR-TENANT%3e.onmicrosoft.com) user account and temp password.

#### Exit criteria

-   You are able to view policies in the web application ![Policies page of the PolicyConnect app.](media/unguided-image41.png "PolicyConnect").

-   Validate you can download policy documents from the Policy Holder details page (File Path) ![The File Path and underlying URL are highlighted, showing the link to the Azure Function Proxy URL created previously.](media/unguided-image42.png "PolicyConnect").

## Exercise 10: Configure and run the legacy desktop (Windows Forms) application

Duration: 15 minutes

Contoso Insurance has created a web and mobile version of their desktop application, but they have opted to update it to communicate with the new Web API service for business and data functionality, doing away with their old WCF services (also included in the solution). They have also replaced their SQL membership-based user authentication with Azure Active Directory (AAD).

If you would like to run the desktop application in its original configuration, you will need to set up a local self-signed certificate, as detailed in [Appendix A](#_Appendix_A:_Create). Also, make sure that you run both WCF services when debugging the desktop application by right-clicking on the Solution, then clicking on Select StartUp Projects. From here, select the Multiple startup projects radio button then select the Start action for the following projects, moving them from top to bottom in this order: PolicyConnectDataService, PolicyConnectManagementService, and PolicyConnectDesktop. Also, make sure that the UseWebApi app setting is set to false in App.config.

### Task 1: Configure application settings in App.config

In this task, you will update the application settings in the App.config file, allowing the desktop application's updated code to take advantage of the new Azure services.

#### Tasks to complete

-   Modify the application settings within the App.config file of the **PolicyConnectDesktop** Starter Project in Visual Studio.

    -   **PdfRootPath**: This is the root folder of the PDF files. This path should point to the folder C:\\ContosoInsurance\\Hackathon\\Files\\.

    -   **RootWebApiPath**: Insert the value of the URL to your published Web API (e.g., <https://contosoinsuranceapi.azurewebsites.net>).

    -   **UseWebApi**: Set to **true**. This allows the desktop app to communicate with the new Web API, and authenticate through Azure AD.

    -   **DesktopClientId**: Insert the value of the Application ID for the Contoso Insurance Desktop Azure AD application (e.g., e5040790-6d06-458d-b4da-8e83fa1c56b1).

    -   **DesktopRedirectUri**: Insert the Redirect URI value from Azure AD for the Contoso Insurance Desktop app (e.g., <http://contosoinsurance.desktop.client>)

    -   **WebApiAppId**: Insert the App URI ID for the Contoso Insurance Web API from Azure AD (e.g., https://\<YOUR-TENANT\>.onmicrosoft.com/e701e991-0aeb-4f91-9a12-5168bb310f72 ). This can be found on the properties blade for the Web API app in Azure AD.

    -   **AzureAdLoginUrl**: This is the URL of your Azure AD tenant, which should be: [https://login.windows.net/\<tenantID](https://login.windows.net/%3ctenantID)\>. You can find your Tenant ID by opening Azure AD and selecting Properties. Your Tenant ID is the Directory ID value.

    -   **AzureADTenantId**: This is the Guid value of your tenant, which you retrieved from Azure AD for the previous key.
    

#### Exit criteria

-   The application settings are updated and saved.

### Task 2: Run the desktop application

#### Tasks to complete

-   Successfully run the desktop application by debugging it in Visual Studio.

-   Select the **Log in** button to begin, and login with the credentials for the Contoso User account you created in your AAD directory. The username is **contosouser@\<your tenant\>.onmicrosoft.com**.

#### Exit criteria

-   You can see a list of policyholders, and you should see a label on the upper-right saying you are logged in as your Contoso User account. Feel free to explore the different capabilities of the application. Some functionality is intentionally left out. To open a policyholder record, simply double-click on any of the rows.

    ![Screenshot of the PolicyConnect Desktop app.](media/unguided-image43.png "PolicyConnect Desktop app")

## Exercise 11: Configure and run the mobile application

Duration: 15 minutes

The mobile application was built using Xamarin Forms, capitalizing on the .NET expertise of the Contoso Insurance development team. As a bonus, they can easily add additional platforms, such as iOS and Windows phone, as well as target multi-platform desktop environments. For now their focus has been on deploying to Android, since they can run the Android emulator right from their development machines, which are Windows-based. You will need to have completed the Xamarin installation steps outlined at the beginning of this hands-on lab guide.

In this exercise, you will update the application settings in the ApplicationSettings.cs file, and then run the mobile application within the Android emulator.

### Task 1: Configure application settings in ApplicationSettings.cs

#### Tasks to complete

-   Modify the properties within the **ApplicationSettings.cs** file of the **PolicyConnectDesktop** Starter Project in Visual Studio.

    -   **RootWebApiPath**: Insert the value of the URL to your published Web API (e.g., <https://contosoinsuranceapi.azurewebsites.net>).

    -   **BlobContainerUrl**: Enter the URL property of your blob storage account **policies** container where the policy PDF files are kept (e.g., <https://contosoinsurancekb.blob.core.windows.net/policies>). You can find this by navigating to your Storage account in Azure, selecting Blobs on the Overview blade, then selecting the policies container, and selecting Properties.

    -   **MobileClientId**: Insert the Application ID, in Guid format, from the Azure AD application settings for your mobile application (e.g., 06e8576a-566d-4582-884f-ce2f99a729bb).

    -   **MobileRedirectUri**: Insert the Redirect URI value from the Azure AD for the Contoso Insurance Mobile app (e.g., <http://contosoinsurance.mobile.client>).

    -   **WebApiAppId**: Insert the App URI ID for the Contoso Insurance Web API from Azure AD (e.g., https://\<YOUR-TENANT\>.onmicrosoft.com/e701e991-0aeb-4f91-9a12-5168bb310f72). This can be found on the properties blade for the Web API app in Azure AD..

    -   **WebApiReplyUrl**: Insert the Reply URL value from Azure AD for the Contoso Insurance Web API (e.g., <https://contosoinsuranceapi.azurewebsites.net>).

    -   **AzureADLoginUrl**: This is the URL of your Azure AD tenant, which should be: [https://login.windows.net/\<tenantID](https://login.windows.net/%3ctenantID)\>. You can find your Tenant ID by opening Azure AD and selecting Properties. Your Tenant ID is the Directory ID value.

    -   **GraphResourceUri**: Set to <https://graph.windows.net>.

    -   **AzureADTenantId**: This is the Guid value of your tenant, which you retrieved from Azure AD for the previous key.

    -   **AzureSearchServiceUrl**: To get this value, go into the Azure portal, select your search service, then the \"policies\" index, and then \"Search explorer." Copy the full URL within the URL field. Make sure to include the entire path, even the \"&search=\*\" at the end (e.g., <https://contosoinsurance.search.windows.net/indexes/policies/docs?api-version=2015-02-28&search=*>).

    -   **AzureSearchQueryApiKey**: Insert the query key value from your Azure Search service, which can be found by selecting your search service in Azure, selecting Keys, then selecting Manage query keys, and copying the displayed key (or create one if none exist) (e.g., 1A80181B30F975CFE252E4FDDAA657DC).

#### Exit criteria

-   The application settings have been saved in ApplicationSettings.cs.

### Task 2: Run the mobile application

#### Task to complete

-   Debug the **CIMobile.Droid** project within the Android emulator.

#### Exit criteria

-   The Android emulator should appear, and then launch the PolicyConnect app within.

    ![Screenshot of the Android emulator.](media/unguided-image44.png "Android emulator")

-   Select the **Sign In** button to begin.

-   You will be presented with an AAD login window. Enter the login credentials for the Contoso User account you created in your AAD directory. Username is **contosouser@\<your tenant\>.onmicrosoft.com**. After authentication is complete, you should see a list of policyholders. You cannot interact with the records in any way for this demo.

-   Select the menu button on the upper-left to explore other parts of the app.

    ![Policy Holders list viewed in the Android emulator.](media/unguided-image45.png "Android emulator")

-   Select the menu and choose **Search Policy \#**.

    ![Search Policy \# is highlighted in the Android emulation.](media/unguided-image46.png "Android emulator")

-   You can either enter a full policy \# or perform a partial search of all content and metadata fields within the search field. Type in at least 3 characters to activate the search button. Try searching with the letters **MON**. The most relevant search results will appear first. Now try searching by an exact policy number, such as **DOW586IJCG493F**. You should see a single result matching that policy number.

    ![Search results are displayed in the Android emulator.](media/unguided-image47.png "Android Emulator")

-   Select a search result to view the content that was extracted by the Azure Search indexer. There is a link to download the actual PDF at the bottom of the result page. This will display the file that is stored in blob storage.

    ![Search resullt details in the Android emulator.](media/unguided-image48.png "Android emulator")
    
    ![Policy document in the Android emulator.](media/unguided-image49.png "Android emulator")

## Exercise 12: Create a Flow app that sends push notifications

Duration: 10 minutes

Contoso wants to receive push notifications when important emails arrive, since any newly scanned policies that are emailed to the data entry employees are marked as important. As they use Office 365 for their email services, you can easily meet this requirement with Flow.

### Task 1: Sign up for a Flow account

#### Tasks to complete

-   Visit <https://flow.microsoft.com> to create an account if you do not already have one.

-   Download the Flow mobile app.

#### Exit criteria

-   You are logged into your Flow account.

### Task 2: Create new flow

#### Tasks to complete

-   Create a new trigger that connects to Office 365 Outlook. Watch for any that is of high importance and have an attachment.

-   Execute a push notification if an email with the preferred criteria arrives in the user's inbox. Make sure that the subject is part of the notification title.

#### Exit criteria

-   You have saved your Flow.

### Task 3: Test your flow

#### Tasks to complete

-   Send a new email to the linked email account that will trigger the notification.

#### Exit criteria

-   If you have installed the Flow mobile app that supports push notifications, you should have received one after the message has been sent.

-   Alternatively, check the status of your flow by going to **My flows**, and then selecting the name of the flow. The resulting page will display a log of each time it was executed. When you select the log entry, you will see which of the steps the email trigger or the push notification was successful.

    ![On the My flows tab, the option to send a mobile notification when a new email arrives is set to On.](media/unguided-image50.png "My Flows tab")

## Exercise 13: Create an app in PowerApps

Duration: 15 minutes

Since creating mobile apps is a long development cycle, Contoso is interested in using PowerApps to create mobile applications in order to quickly add functionality not currently offered by their app. In this scenario, they want to be able to edit the Policy lookup values (Silver, Gold, Platinum, etc.), which they are unable to do in the current app.

Get them up and running with a new app created in PowerApps, which connects to the ContosoInsurance database and performs basic CRUD (Create, Read, Update, and Delete) operations against the Policies table.

### Task 1: Sign up for a PowerApps account

#### Tasks to complete

-   Go to <https://web.powerapps.com> and sign up for a new account, or sign in with an existing one.

-   Download and install the PowerApps Studio application from the Microsoft store:

    -   <https://www.microsoft.com/en-us/store/p/powerapps/9nblggh5z8f3>

#### Exit criteria

-   You are logged into your PowerApps account.

-   You have installed the PowerApps Studio application.

### Task 2: Create a new SQL connection

#### Tasks to complete

-   From the <https://web.powerapps.com> website, create a new SQL connection and enter the server name, database name, username, and password for the ContosoInsurance database hosted in Azure.

#### Exit criteria

-   You have a connection to your Azure SQL Database.

### Task 3: Create a new app

#### Tasks to complete

-   Launch the PowerApps desktop application and create a new app, using the SQL connection pointing to the Policies table.

#### Exit criteria

-   You have an app connected to your SQL database connection.

### Task 4: Design app

#### Tasks to complete

-   After the app has been generated, change the titles on each of the three screens to remove the database table name.

-   Remove any unneeded labels from the list view screen.

-   Rearrange the order of the fields within the details and the edit form screens.

-   Fix up the labels for the field names to make them more human readable.

#### Exit criteria

-   You have set up your app.

### Task 5: Edit the app settings and run the app

#### Tasks to complete

-   Change the name of the app.

-   Save the app to the cloud.

-   Run the app to test the app's ability to display and edit the list of Policies.

#### Exit criteria

-   The PowerApps Studio application comes with a powerful app simulator in which you can test the app against your data source in real time. You should be able to view all of the Policies, edit them, create new ones, and delete the newly created ones. You will be unable to delete existing Policies since they are being referenced by other table records.

    ![All of the Policy options display.](media/unguided-image51.png "Policies section")

## Exercise 14: Add Azure Function to Azure API Management

Duration: 15 minutes

Contoso is interested in providing an API Store experience to the development teams. In this exercise you will create an API Managemenent portal and import the Function app you created earlier.

### Task 1: Provision Azure API Management

In this task, you will create a new API Management Resource.

#### Tasks to complete

-   Create a new Azure API Management Service.

    > **Note**: It will take several minutes to provision the APIM resource. You can safely move on to the next task.

#### Exit criteria

-   You have set up your API Management Service.

### Task 2: Add API Definition to Function App

In this task, you will generate a swagger api definition for the policy documents Function App. This is required for API Management to discover the API.

#### Tasks to complete

-  Generate a swagger 2.0 api definition for the Policy Docs function app.

#### Exit criteria

- The function app has a swagger definition.

### Task 3: Import the Funtion App to API Management(APIM)

In this task, you will add your function app to the APIM's api collection.

#### Tasks to complete

-  Use the APIs blade to import your function app into the APIM service.

    > **Note**: A pop up indicating that you should replace the Named Values with the function secrets will appear. In this lab, this step will not be required. Select Ok to disregard.

    ![Import Function App pop up is displayed](media/image218.png "Import Function App Pop")

#### Exit criteria

-  The function app api is available within the APIM service.

### Task 4: Test the APIM Developer Portal

In this task, you will test an API from the APIM Developer Portal.

#### Tasks to complete

-  Use the Try It feature on the APIM developer portal to test the function app api.

    -  Example testing values:
       -  **policyHolder**: Albert
       -  **policyNumber**: ALB417974T1SV1

#### Exit criteria

-  You receive a 200 okay response with a payload of binary data representing a pdf file.

## After the hands-on lab

Duration: 10 minutes

In this exercise, you will deprovision any Azure resources that were created in support of the lab.

### Task 1: Delete the Resource group in which you placed your Azure resources.

-   From the Portal, navigate to the blade of your Resource Group and select Delete in the command bar at the top.

-   Confirm the deletion by re-typing the resource group name and selecting Delete.

### Task 2: Delete the Azure Active Directory app registrations for Desktop and Mobile

-   Open the manifest for each app registration and change the following setting to false:

    -   **"availableToOtherTenants"**: false

-   Save the manifest, then delete the app registrations.

### Task 3: Delete Flow

-   In your Microsoft Flow account, delete the Flow you created to send a push notification when email messages marked as important with an attachment are received in your inbox.

You should follow all steps provided *after* attending the hands-on lab.

## Appendix A: Create a self-signed certificate

For users who wish to run the PolicyConnect desktop application within its legacy configuration, you must create and configure a self-signed certification. SSL is used to encrypt communication between the desktop application and the WCF services, including SQL-based authentication. **This is not required to complete the lab successfully.**

### Task 1: Create self-signed certificate

1.  On the new VM, run the **Developer Command Prompt** for the appropriate version of Visual Studio as an [administrator]{.underline} from the Start menu.

2.  Browse to a folder location you wish to store the certificate files. Take note of the path.

3.  Run the following command to create the root CA, and execute:

    ```
    makecert -n "CN=RootCATest" -r -sv RootCATest.pvk RootCATest.cer
    ```

By default, no **makecert** tool is installed on Windows 10 PC. To install, you need to download Windows 10 SDK from here: <https://developer.microsoft.com/en-us/windows/downloads/windows-10-sdk>.

4.  In the **Create Private Key Password** dialog box, select **None** without entering the password. Normally this is not recommended for security reasons but is acceptable for test purposes only.

5.  Now you will install the certificate in the Trusted Root Certification Authorities container.

6.  Select **Start**, then type **MMC** and then select **OK**. On Windows 10, you will need to type **mmc.exe** after selecting **Start**.

7.  In the Microsoft Management Console (MMC), on the **File** menu, select **Add/Remove Snap-in**.

8.  In the **Add Standalone Snap-in** dialog box, select **Certificates** and then select **Add**.

    ![In the Add or Remove Snap-ins dialog box, the Certificates snap-in and the Add button are selected.](media/unguided-image52.png "Add or Remove Snap-ins dialog box")

9.  In the **Certificates snap-in** dialog box, select the **Computer account** radio button because the certificate needs to be made available to all users, and then select **Next**.

10. In the **Select Computer** dialog box, leave the default **Local computer** (the computer this console is running on) selected and then select **Finish**.

11. In the **Add/Remove Snap-in** dialog box, select **OK**.

12. In the left pane, expand the **Certificates (Local Computer)** node, and then expand the Trusted Root Certification Authorities folder.

13. Under **Trusted Root Certification Authorities**, right-click the Certificates subfolder, select **All Tasks**, and then select **Import**.

14. On the **Certificate Import Wizard** welcome screen, select **Next**.

15. On the **File to Import** screen, select **Browse**.

16. Browse to the location of the signed Root Certificate Authority RootCATest.cer file copied in Step 3, select the file, and then select **Open**.

17. On the **File to Import** screen, select **Next**.

18. On the **Certificate Store** screen, accept the default choice and then select **Next**.

19. On the **Completing the Certificate Import Wizard** screen, select **Finish**.

    ![In the MMC window - console1, under Console Root\\Certificates (Local Computer), Trusted Root Certification Authorities is selected. Under Issued To, RootCATest is selected.](media/unguided-image53.png "MMC window - console1")

20. Leave the MMC window open, as it will be required below.

### Task 2: Create and install your temporary service certificate

1.  On the new VM, run the **Developer Command Prompt** for the appropriate version of Visual Studio as an [administrator]{.underline} from the Start menu, or switch over to the command prompt if you had left it open from the previous steps.

2.  Browse to the folder location you stored the certificate files.

3.  Type in the following command, replacing the \<\<YOUR MACHINE NAME\>\> with your machine name, and execute:

    ```
    makecert -sk ContosoInsurance -iv RootCATest.pvk -n "CN=<<YOUR MACHINE NAME>>" -ic RootCATest.cer -sr localmachine -ss my -sky exchange -pe
    ```
4.  Keep the command prompt open.

5.  You must now associate this certificate with all SSL transactions within IIS Express. To do this, **re-open the Certificates MMC snap-in** from the previous section.

6.  **Expand** the Personal certificates node on the Certificates tree to the left. You should see a certificate issued to your machine name and issued by RootCATest. **Double-click your certificate**, then select the **Thumbprint** field under the Details tab. **Copy the Thumbprint value**.

    ![In the MMC window - console1, under Certificate\\Personal, Certificates is selected. Under Issued To, the RootCATest certificate is selected. In the Certificate dialog box Details tab, the thumbprint value is selected.](media/unguided-image54.png "MMC window - console1, and Certificate dialog box")

7.  **Launch PowerShell** from the start menu. You will run a command to remove the spaces from the Thumbprint value you copied on the previous step. You will also execute a command to generate a new Guid value.

8.  From the PowerShell command prompt, **paste your certificate's thumbprint between double quotes** and execute the following command (replacing the thumbprint value with your own):

    \"a1 b6 9e 7a be 27 fe 21 fa c7 21 f5 40 72 9f c1 f5 8c dc 4e\" -replace \" \"

9.  **Copy the output value**, which is your thumbprint with the spaces removed.

10. Go back to the Visual Studio command prompt you left open on step 4. Type in the following command, but **do not execute yet**:

    > netsh http add sslcert ipport=0.0.0.0:44321 appid={c19c7312-ffe4-48da-85e3-f302ad80a625} certhash=a1b69e7abe27fe21fac721f540729fc1f58cdc4e

11. Replace the **certhash** value with the thumbprint you copied in the previous step. Replace the **appid** value with a newly generated Guid. To generate a Guid, switch pack to PowerShell and execute the following command:

    ```powershell
    [guid]::NewGuid()
    ```

12. Paste the output Guid value in between the curly braces next to **appid** in the Visual Studio command prompt.

13. Execute the netsh command. If you receive an error stating that the "SSL Certificate add failed," you may ignore it. The certificate is now associated with https communications over port 44321.

### Task 3: Configure the IIS Express self-signed certificate

1.  On the new VM, verify that the IIS Express developer certificate bound to localhost is present.

2.  Select **Start**, type **MMC,** and then select **OK**.

3.  In the Microsoft Management Console (MMC), on the **File** menu, select **Add/Remove Snap-in**.

4.  In the **Add Remove Snap-in** dialog box, select **Add**.

5.  In the **Add Standalone Snap-in** dialog box, select **Certificates,** and then select **Add**.

6.  In the **Certificates snap-in** dialog box, select the **Computer account** radio button because the certificate needs to be made available to all users, and then select **Next**.

7.  In the **Select Computer** dialog box, leave the default **Local computer** (the computer this console is running on) selected, and then select **Finish**.

8.  In the **Add Standalone Snap-in** dialog box, select **Close**.

9.  In the **Add/Remove Snap-in** dialog box, select **OK**.

10. In the left pane, expand the **Certificates (Local Computer)** node, and then expand the **Personal** folder.

11. You should see a certificate issued to and issued by "localhost".

    ![In the MMC window - console1 window, the certificate issued to localhost is selected.](media/unguided-image55.png "MMC window - console1")

12. If this certificate is not present, you will need to run a repair command for the IIS Express application. If it is present, continue to step 12.

    a.  Select **Start**, then type in **Programs and Features**. Select the **Programs and Features** application link.

    b.  Find and right-click on the IIS Express application listing, then select **Repair**.

       ![The right-click menu for IIS 10.0 Express displays with Repair selected.](media/unguided-image56.png "Repair menu option")

    c.  Once the repair has completed, go back to the Certificates MMC snap-in and verify that the localhost certificate is now present under the Personal folder.

13. From the Certificates MMC snap-in, right-click on the localhost certificate within the Personal certificates container, then choose **All Tasks Export**...

    ![In the MMC window - console1 window, under Certificates\\Personal, Certificates is selected. Under Issued to, the right-click menu for localhost displays, and All Tasks / Export is selected.](media/unguided-image57.png "MMC window - console1 window")

14. When the Certificate Export Wizard dialog appears, select **Next**. Under **Export Private Key**, select **Yes, export the private key**, and then click **Next**.

    ![The Certificate Export Wizard displays.](media/unguided-image58.png "Certificate Export Wizard")

15. Make sure the **Personal Information Exchange -- PKCS \#12 (.PFX)** file format is selected, and that the first checkbox (include all certificates in the certification path if possible) is checked, leaving the other three unchecked. Select **Next**..

    ![In the Certificate Export Wizard, Export File Format section, Personal Information Exchange -- PKCS \#12 (.PFX) is selected.](media/unguided-image59.png "Certificate Export Wizard")

16. Enter and confirm a password on the next step. **Make note of the password** for the certificate import process. Select **Next**.

17. Specify the name of your exported file by browsing to a folder and typing in the name of the file (such as localhost). Select **Next**.

18. Select **Finish** on the confirmation screen. You will receive a prompt stating that the export was successful. Select **OK** to close the dialog.

19. After the export is complete, expand the **Trusted Root Certification Authorities** folder, then right-click on the Certificates subfolder and select **All Tasks...** **Import**.

20. Select **Next**, and then browse to the exported certificate location. You may need to select **Personal Information Exchange (\*.pfx,\*.p12)** from the file types dropdown next to the filename field in order to see your certificate listed. Select the certificate, select **Open**, and then **Next**.

21. Type the password you entered while exporting the certificate in step 15, then select **Next**.

22. Make sure that the **Trusted Root Certification Authorities** certificate store is selected, then select **Next**, then **Finish**. You will receive a prompt stating that the import was successful. Select **OK** to close the dialog.