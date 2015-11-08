echo "Demonstrating requirement 1,3,4,6"
"./Executive/bin/Debug/Executive.exe" "./testcode" *.cs /X

echo "Demonstrating requirement 1,2,3,4"
"./Executive/bin/Debug/Executive.exe" "./testcode" *.cs /S

echo "Demonstrating requirement 1,2,3,4,5"
"./Executive/bin/Debug/Executive.exe" "./testcode" *.cs /R /S
