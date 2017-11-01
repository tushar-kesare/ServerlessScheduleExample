$sourcePath = "./src/ServerlessExample/bin/release/netcoreapp1.0/publish"
$targetPath = "./bin/deployment-archive.zip"

If ((Test-Path "./bin") -eq $false) {
   New-Item -ItemType Directory "./bin"
}

If (Test-Path $targetPath) {
    Write-Host "Removing existing artifact at $targetPath"
	Remove-Item $targetPath
}

Write-Host "Packaging project binaries from '$sourcePath' to '$targetPath'"
Add-Type -Assembly System.IO.Compression.FileSystem
[IO.Compression.ZipFile]::CreateFromDirectory($sourcePath, $targetPath)
