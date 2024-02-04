$folders = @("core", "feature-management", "validation");

foreach ($folder in $folders) {
    Push-Location $folder
    buf mod update
    Pop-Location
}
