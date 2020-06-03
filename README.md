# .NET Modernization In a Day

This workshop is designed for Microsoft partners to drive the migrations of .NET applications to Azure across customers. It includes whiteboard design session materials and hands-on lab. Content is based on Microsoft Cloud Workshops, that are widely used by Microsoft specialists and solution architects.

April 2020

## Before you start

- Take a look at a partner marketing materials for [.NET Modernization In a Day](https://partner.microsoft.com/en-us/asset/collection/net-modernization-in-a-day)
- Review [How to deliver .NET Modernization In a Day workshop](https://note.microsoft.com/US-NOGEP-WBNR-FY20-04Apr-28-AppModernization-SRDEM17754_Registration.html) session recording

## Abstracts

### Workshop

In this workshop, you gain a better understanding of the steps involved in modernizing .NET applications and legacy infrastructure by leveraging cloud services. You also see how applications can be enhanced by adding a mix of web and mobile services, all secured using Azure Active Directory.

At the end of this workshop, your ability to design and implement a modernization plan for organizations looking to move services from on-premises to the cloud will be improved.

### Customer situation

Contoso, Ltd. (Contoso) is a new company in an old business. Founded in Auckland, NZ, in 2011, they provide a full range of long-term insurance services to help individuals who are under-insured, filling a void their founders saw in the market. From the beginning, they grew faster than anticipated and have struggled to cope with rapid growth. During their first year alone, they added over 100 new employees to keep up with the demand for their services. To manage policies and associated documentation, they use a custom-developed Windows Forms application, called PolicyConnect. PolicyConnect uses an on-premises SQL Server 2008 R2 database as its data store, along with a file server on its local area network for storing policy documents. That application and its underlying processes for managing policies have become increasingly overloaded.

Contoso recently started a new web and mobile projects to allow policyholders, brokers, and employees to access policy information without requiring a VPN connection into the Contoso network. The web project is a .NET Core 2.2 MVC web application, which accesses the PolicyConnect database using REST APIs. They eventually intend to share the REST APIs across all their applications, including the mobile app and WinForms version of PolicyConnect. They have a prototype of the web application running on-premises and are interested in taking their modernization efforts a step further by hosting the app in the cloud. However, they don't know how to take advantage of all the managed services of the cloud since they have no experience with it. They would like some direction converting what they have created so far into a more cloud-native application.

They have not started the development of a mobile app yet. Contoso is looking for guidance on how to take a .NET developer-friendly approach to implement the PolicyConnect mobile app on Android and iOS.

To prepare for hosting their applications in the cloud, they would like to migrate their SQL Server database to a PaaS SQL service in Azure. Contoso is hoping to take advantage of the advanced security features available in a fully managed SQL service in the Azure. By migrating to the cloud, they hope to improve their technological capabilities and take advantage of enhancements and services that are enabled by moving to the cloud. The new features they would like to add are automated document forwarding from brokers, secure access for brokers, access to policy information, and reliable policy retrieval for a dispersed workforce. They have been clear that they will continue using the PolicyConnect WinForms application on-premises but want to update the application to use cloud-based APIs and services. Additionally, they want to store policy documents in cloud storage for retrieval via the web and mobile apps.

### Part I: Presentation
Start from presenting .NET Modernization with Azure story using the [included deck.](Presentation) Presentation should take 60-90 minutes and introduce the aspects of .NET app modernization and value that Azure brings.

### Part II: Whiteboard Design Session

During [whiteboard design session](Whiteboard%20design%20session), you work with a group to design a solution for modernizing legacy on-premises applications and infrastructure by leveraging cloud services. As part of the modernization effort, application enhancements are added using a mix of web and mobile services, all secured using Azure Active Directory.

At the end of this whiteboard design session, you will design a modernization plan for organizations looking to move services from on-premises to the cloud will be improved.

If you are delivering the session remotely, we suggest to use [Microsoft Teams](https://products.office.com/microsoft-teams) and [Microsoft Whiteboard.](https://whiteboard.microsoft.com)

### Part III: Hands-on Lab

[Hands-on lab](Hands-on%20lab) is designed to guide attendees through the process of implementing the steps to modernize a legacy .NET-based on-premises application, including upgrading and migrating the database to Azure and updating the application to take advantage of serverless and cloud services.

At the end of this hands-on lab, you will build a solution for modernizing legacy on-premises applications and infrastructure using cloud services like Azure App Service and Azure SQL Database.

## Azure services and related products

- API Management
- App Services
- Azure Active Directory
- Azure Cognitive Services
- Azure Database Migration Service
- Azure Key Vault
- Azure Redis
- Azure Cognitive Search
- Azure SQL Database
- Azure Storage
- Azure Virtual Machines
- Flow
- PowerApps
- Visual Studio
- Xamarin

## Related references

- [MCW](https://microsoftcloudworkshop.com)
- [Reference architecture for Managed Web Applications](https://docs.microsoft.com/azure/architecture/reference-architectures/app-service-web-app/basic-web-app)
- [Azure application architecture guide](https://docs.microsoft.com/azure/architecture/guide/)

## Help & Support

We welcome feedback and comments from Microsoft SMEs & learning partners who deliver MCWs.  

***Having trouble?***
- First, verify you have followed all written lab instructions (including the Before the Hands-on lab document).
- Next, create a new Issue in the repo with detailed description of the issue and any troubleshooting steps performed.

If you are planning to present a workshop, *review and test the materials early*! We recommend at least two weeks prior.

Leave your comments by creating a new topic in Issues section or send an email to appinnovationinaday@microsoft.com with any questions.
