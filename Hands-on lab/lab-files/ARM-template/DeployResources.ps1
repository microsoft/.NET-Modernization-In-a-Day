
$resourceGroup= "DotNetAppModernization"
$location = "North Europe"
az login

az account set --subscription 1665253c-71bf-46a4-b851-2d53ac6f9766
az group create --name $resourceGroup --location $location
az group deployment  create --resource-group $resourceGroup --name "deploy_new_training" --template-file azure-deploy.json 