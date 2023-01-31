param($newname)

Get-ChildItem -Path "." -Recurse -File |
ForEach-Object {
    (Get-Content $_.FullName) |
    Foreach-Object { $_ -replace 'PocMinimalApi', $newname } |
    Set-Content $_.FullName
}