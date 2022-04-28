$server="hackteam1-azuresql-server"
$resourceGroup = "2022-hack-team-1-WES"
$location = "West US"
$login="azureuser"
$password="Pa$$w0rD-$randomIdentifier"

az sql server create --name $server --resource-group $resourceGroup --location "$location" --admin-user $login --admin-password $password