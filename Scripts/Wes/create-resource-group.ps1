$resourceGroup = "2022-hack-team-1-WES"
$location = "West US"

Get-AzResourceGroup -Name $resourceGroup  -ErrorVariable notPresent -ErrorAction SilentlyContinue

if ($notPresent)
{
    New-AzResourceGroup -Name $resourceGroup -Location $location
}
