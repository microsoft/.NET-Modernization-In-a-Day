
$resourceGroup= "dotnet-modernization"
$location = "West Europe"
az login

az account set --subscription 5d9a229f-3bb4-46fb-9995-4d0625c98a34
az group create --name $resourceGroup --location $location
az deployment group create -g $resourceGroup --name "deploy_new_training" --template-file azure-deploy_CI_CD.json 