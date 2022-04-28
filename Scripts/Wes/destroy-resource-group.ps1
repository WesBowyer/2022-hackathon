$resourceGroup = "2022-hack-team-1-WES"

Get-AzResourceGroup -Name $resourceGroup -ErrorVariable notPresent -ErrorAction SilentlyContinue

if ($notPresent)
{
    Write-Output "ResourceGroup does not exist"
}
else {
    Remove-AzResourceGroup -name $resourceGroup    
    Write-Output "Removed resource group"
}

