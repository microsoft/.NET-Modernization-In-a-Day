
#use this file to deploy the CI_CD version of the HOL, the CI_CD version does not contain any VM components
#this is just a helper script noting major.
$resourceGroup= "dotnet-modernization"
$location = "West Europe"
$subscription = ""
az login

# find the subscription id that you want to use

az account set --subscription $subscription
az group create --name $resourceGroup --location $location
az deployment group create -g $resourceGroup --name "deploy_new_training" --template-file azure-deploy_CI_CD.json 