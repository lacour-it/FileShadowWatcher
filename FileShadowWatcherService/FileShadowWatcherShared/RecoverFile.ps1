param (
	[string]$Volume = 'C:',
	[Parameter(Mandatory=$true)][string]$InPath,
	[Parameter(Mandatory=$true)][string]$OutPath
)
$Volume2 = $InPath.Substring(0,2)
if ($Volume.Length -le $Volume2.Length)
{
	$Volume = $Volume2
}
#Import-Module PowerForensicsv2
#E:\BriefPrivat.dotx
#C:\Briefprivat.dotx
$FObject = Get-ForensicFileRecord -VolumeName E: | Where-Object {$_.Deleted} | Where-Object {$_.FullName -eq $InPath}
$FData=$FObject.Attribute | Where-Object {$_.name -eq 'DATA'}
$FRun = $FData.DataRun
$FRealSize =$FData.RealSize-1
$FStartCluster = $FRun.StartCluster
$FClusterLength = $FRun.ClusterLength
$FVolumeInformation = Get-ForensicVolumeBootRecord -Volume E:
$FClusterBytes =$FVolumeInformation.BytesPerCluster
$FOffset = $FStartCluster*$FClusterBytes
$FBlocSize=$FClusterLength*$FClusterBytes
$TempFile = 'C:\Windows\Temp\cprf.tmp'
Invoke-ForensicDD -InFile \\.\E: -OutFile $TempFile -Offset $FOffset -Blocksize $FBlocSize -Count 1
[Byte[]]$bytes = [System.IO.File]::ReadAllBytes($TempFile)
$bytes = $bytes[0..$FRealSize]
[System.IO.File]::WriteAllBytes($OutPath,$bytes)
Remove-Item $TempFile