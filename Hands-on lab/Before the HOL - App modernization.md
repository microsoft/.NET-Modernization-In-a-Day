![Microsoft Cloud Workshops](https://github.com/Microsoft/MCW-Template-Cloud-Workshop/raw/master/Media/ms-cloud-workshop.png "Microsoft Cloud Workshops")

<div class="MCWHeader1">
App modernization
</div>

<div class="MCWHeader2">
Before the hands-on lab setup guide
</div>

<div class="MCWHeader3">
February 2020
</div>

Information in this document, including URL and other Internet Web site references, is subject to change without notice. Unless otherwise noted, the example companies, organizations, products, domain names, e-mail addresses, logos, people, places, and events depicted herein are fictitious, and no association with any real company, organization, product, domain name, e-mail address, logo, person, place or event is intended or should be inferred. Complying with all applicable copyright laws is the responsibility of the user. Without limiting the rights under copyright, no part of this document may be reproduced, stored in or introduced into a retrieval system, or transmitted in any form or by any means (electronic, mechanical, photocopying, recording, or otherwise), or for any purpose, without the express written permission of Microsoft Corporation.

Microsoft may have patents, patent applications, trademarks, copyrights, or other intellectual property rights covering subject matter in this document. Except as expressly provided in any written license agreement from Microsoft, the furnishing of this document does not give you any license to these patents, trademarks, copyrights, or other intellectual property.

The names of manufacturers, products, or URLs are provided for informational purposes only and Microsoft makes no representations and warranties, either expressed, implied, or statutory, regarding these manufacturers or the use of the products with any Microsoft technologies. The inclusion of a manufacturer or product does not imply endorsement of Microsoft of the manufacturer or product. Links may be provided to third party sites. Such sites are not under the control of Microsoft and Microsoft is not responsible for the contents of any linked site or any link contained in a linked site, or any changes or updates to such sites. Microsoft is not responsible for webcasting or any other form of transmission received from any linked site. Microsoft is providing these links to you only as a convenience, and the inclusion of any link does not imply endorsement of Microsoft of the site or the products contained therein.

© 2020 Microsoft Corporation. All rights reserved.

Microsoft and the trademarks listed at <https://www.microsoft.com/en-us/legal/intellectualproperty/Trademarks/Usage/General.aspx> are trademarks of the Microsoft group of companies. All other trademarks are property of their respective owners.

**Contents**

<!-- TOC -->

- [App modernization before the hands-on lab setup guide](#app-modernization-before-the-hands-on-lab-setup-guide)
  - [Requirements](#requirements)
  - [Before the hands-on lab](#before-the-hands-on-lab)
    - [Task 1: Provision a resource group](#task-1-provision-a-resource-group)
    - [Task 2: Register required resource providers](#task-2-register-required-resource-providers)
    - [Task 3: Run ARM template to provision lab resources](#task-3-run-arm-template-to-provision-lab-resources)

<!-- /TOC -->

# App modernization before the hands-on lab setup guide

## Requirements

- Microsoft Azure subscription must be pay-as-you-go or MSDN.
  - Trial subscriptions will *not* work.
- **IMPORTANT**: To complete this lab, you must have sufficient rights within your Azure AD tenant to:
  - Create an Azure Active Directory application and service principal
  - Assign roles on your subscription
  - Register resource providers

## Before the hands-on lab

Duration: 45 minutes

In this exercise, you set up an environment for use in the rest of the hands-on lab. You should follow all steps provided *before* attending the Hands-on lab.

> **IMPORTANT**: Many Azure resources require globally unique names. Throughout these steps the word "SUFFIX" appears as part of resource names. You should replace this with your Microsoft alias, initials, or another value to ensure resources are uniquely named.

### Task 1: Provision a resource group

In this task, you create an Azure resource group to serve as a container for the resources used throughout this lab.

1. In the [Azure portal](https://portal.azure.com), select **Resource groups** from the Azure services list.

    ![Resource groups is highlighted in the Azure services list.](media/azure-services-resource-groups.png "Azure services")

2. On the Resource groups blade, select **+Add**.

    ![+Add is highlighted in the toolbar on Resource groups blade.](media/resource-groups-add.png "Resource groups")

3. On the Create a resource group **Basics** tab, enter the following:

    - **Subscription**: Select the subscription you are using for this hands-on lab.
    - **Resource group**: Enter **hands-on-lab-SUFFIX** as the name of the new resource group.
    - **Region**: Select the region you are using for this hands-on lab.

    ![The values specified above are entered into the Create a resource group Basics tab.](media/create-resource-group.png "Create resource group")

4. Select **Review + Create**.

5. On the **Review + create** tab, ensure the Validation passed message is displayed and then select **Create**.

### Task 2: Register required resource providers

In this task, you register the `Microsoft.DataMigration` and `Microsoft.Search` resource providers within your Azure subscription. These resource providers allow Azure Cognitive Search and the Azure Database Migration Service to be provisioned within your subscription.

1. In the [Azure portal](https://portal.azure.com), select **Subscriptions** from the Azure services list.

    ![Subscriptions is highlighted in the Azure services list.](media/azure-services-subscriptions.png "Azure services")

2. Select the subscription you are using for this hands-on lab from the list, select **Resource providers**, enter "migration" into the filter box, select **Microsoft.DataMigration** and then select **Register**.

    ![The Subscription blade is displayed, with Resource providers selected and highlighted under Settings. On the Resource providers blade, migration is entered into the filter box, and Register is highlighted next to Microsoft.DataMigration.](media/azure-portal-subscriptions-resource-providers-register-microsoft-datamigration.png "Resource provider registration")

3. It can take a couple of minutes for the registration to complete. Make sure you see a status of **Registered** before moving on. You may need to select **Refresh** to see the updated status.

    ![Registered is highlighted next to the Microsoft.DataMigration resource provider.](media/resource-providers-datamigration-registered.png "Microsoft DataMigration Resource Provider")

4. Next, enter "search" into the filter box to locate the `Microsoft.Search` resource provider. If the status is not **Registered**, select **Register**, and wait for the resource status to be registered.

   ![The Register button is highlighted, search is entered into the filter box, and the Microsoft.Search resource provider is selected.](media/resource-providers-search.png "Microsoft Search Resource Provider")

   > **Note**: You may need to select Refresh to see the updated status.

### Task 3: Run ARM template to provision lab resources

In this task, you run an Azure Resource Manager (ARM) template to deploy and configure the resources used throughout this hands-on lab. The resources created by the ARM template include:

- Azure Blob Storage account
- A lab virtual machine (VM) with Visual Studio 2019 Community edition and SQL Server Management Studio (SSMS) installed.
- A SQL Server 2008 R2 VM with the Microsoft Data Migration Assistant (DMA) installed and a copy of the ContosoInsurance database installed.
- Azure SQL Database
- Azure Database Migration Service (DMS)
- Azure App Service Plan
- App Service (Web App)
- App Service (API App)
- Function App
- API Management
- Key Vault
- Azure Cognitive Search
- Azure Cognitive Services account
- Virtual Network

> **Note**: You can review the steps to manually provision the lab resources in the [Manual resource setup guide](./Manual-resource-setup.md).

1. To run the ARM template deployment, select the **Deploy to Azure** button below, which opens a custom deployment screen in the Azure portal.

    <a href ="https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Fmicrosoft%2FMCW-App-modernization%2Fmaster%2FHands-on%20lab%2Flab-files%2FARM-template%2Fazure-deploy.json" target="_blank" title="Deploy to Azure">
    <img src="http://azuredeploy.net/deploybutton.png"/>
    </a>

2. On the custom deployment screen in the Azure portal, enter the following:

    - **Subscription**: Select the subscription you are using for this hands-on lab.
    - **Resource group**: Select the hands-on-lab-SUFFIX resource group from the dropdown list.
    - **Location**: Select the location you used for the hands-on-lab-SUFFIX resource group.
    - **SQL Server Name**: Accept the default value, **contosoinsurance**.


    > **Note**: The actual name must be globally unique, so a unique string is generated from your Resource Group Id and appended to the name during provisioning.

    - **Admin Username**: Accept the default value, **demouser**.
    - **Admin Password**: Accept the default value, **Password.1!!**.
    - **API Management Email**: Enter an email to use for admin notifications from API Management.
    - Check the box to agree to the Azure Marketplace terms and conditions.

    ![The Custom deployment blade displays, and the information above is entered on the Custom deployment blade.](media/azure-custom-deployment.png "Custom deployment blade")

3. Select **Purchase** to start provisioning the lab resources.

    > **Note**: The deployment of the custom ARM template takes about 30 minutes to complete. If you receive any errors, you can manually provision the missing resources following the steps within the [Manual resource setup guide](./Manual-resource-setup.md). If the error indicates an issue with quotas in the region you selected for the resource group, you can delete the resource group, create a new resource group in a different region, and re-run the ARM template, or you can request a quota increase and then manually provision the missing resources.

4. You can monitor the progress of the deployment by navigating to the hands-on-lab-SUFFIX resource group in the Azure portal and then selecting **Deployments** from the left-hand menu. The deployment should be named **Microsoft.Template**. Select the deployment item to view the progress of each individual component in the template.

    ![The Deployments menu item is selected in the left-hand menu of the hands-on-lab-SUFFIX resource group and the Microsoft.Template deployment is highlighted.](media/resource-group-deployments.png "Resource group deployments")

You should follow all steps provided *before* attending the Hands-on lab.
