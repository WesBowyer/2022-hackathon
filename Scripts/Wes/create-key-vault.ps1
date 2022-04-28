$ResourceGroup = "2022-hack-team-1-WES"
$location = "WestUS"

New-AzKeyVault -ResourceGroupName @ResourceGroup -VaultName "Hack-team-1-key-vault"