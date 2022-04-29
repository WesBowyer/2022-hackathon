$resourceGroup = "2022-hack-team-1"
$location = "West US"

Write-Host "Creating resource group"

Get-AzResourceGroup -Name $resourceGroup  -ErrorVariable notPresent -ErrorAction SilentlyContinue

if ($notPresent)
{
    New-AzResourceGroup -Name $resourceGroup -Location $location
}

Write-Host "Creating resource group completed"