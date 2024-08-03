powershell -Command "& {ls *.dwg | Rename-Item -NewName {$_.name -creplace [char]225, [char]97}}"
powershell -Command "& {ls *.dwg | Rename-Item -NewName {$_.name -creplace [char]233, [char]101}}"
powershell -Command "& {ls *.dwg | Rename-Item -NewName {$_.name -creplace [char]237, [char]105}}"
powershell -Command "& {ls *.dwg | Rename-Item -NewName {$_.name -creplace [char]243, [char]111}}"
powershell -Command "& {ls *.dwg | Rename-Item -NewName {$_.name -creplace [char]250, [char]117}}"
powershell -Command "& {ls *.dwg | Rename-Item -NewName {$_.name -replace [char]193, [char]65}}"
powershell -Command "& {ls *.dwg | Rename-Item -NewName {$_.name -replace [char]201, [char]69}}"
powershell -Command "& {ls *.dwg | Rename-Item -NewName {$_.name -replace [char]205, [char]73}}"
powershell -Command "& {ls *.dwg | Rename-Item -NewName {$_.name -replace [char]211, [char]79}}"
powershell -Command "& {ls *.dwg | Rename-Item -NewName {$_.name -replace [char]218, [char]85}}"
echo FINALIZADO
pause