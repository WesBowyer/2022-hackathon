Write-Output "Provisioning Application Resources"

Connect-AzAccount

$script = $PSScriptRoot+"\create-resoure-group.ps1"
& $script

$script = $PSScriptRoot+"\create-vm.ps1"
& $script

Write-Output "Provisioning Application Resources Completed"