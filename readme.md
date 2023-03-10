# wTouch
I created this project because I missed the `touch` command on Windows and I couldn't bother to search for a solution.
So I created one myself, you know, for science.

Just like in Linux, the touch command is used to create a new file or update the timestamp of an existing file. 
When you run the touch command, it checks whether the specified file exists. If the file exists, it updates the file's 
modification and access timestamps to the current time. If the file does not exist, it creates an empty file with the 
specified name.

The touch command is a simple utility that is commonly used to create new files, update timestamps, or ensure that 
a file exists without modifying its content. The command takes one or more file names as arguments, and can also 
accept various options to modify its behavior.

## Usage
## Create new file
```shell
touch <new-file1> <new-file2> <new-file3> ...
```

## Update timestamp
```shell
touch <existing-file1> <existing-file2> <existing-file3> ...
```

## Create new file and update timestamp

> This feature is not yet implemented

```shell
touch -t 202203031300 my-existing-file.txt
```

This command creates a new file named `my-existing-file.txt` with a modification time of March 3rd, 2022 at 1:00 PM. 
The -t option specifies the timestamp in the format YYYYMMDDhhmm, where YYYY is the year, MM is the month, DD is the
day, hh is the hour, and mm is the minute.


# Devops
I wanted to learn more about Github Workflows and actions, so I created two pipelines: 
1. [Build and Publish Release](.github/workflows/publish.yml): This pipeline builds the project, generates a zip file, creates a new Release and publishes the zip into that Github release.
   - TODO on this pipeline: Skip deployment if the release already exists.
2. [Functional Testing](./.github/workflows/functionalTest.yml): This pipeline runs the functional tests on the current branch for every pull request and (just to double-check) whenever code is pushed to the main branch.
   - It's worth noting that I test this application in Linux, but just for completeness, because Linux already have the touch command. 


# Notes
- Provided AS-IS, no warranty, no support, no nothing. (Well, maybe support if someone opens an issue...)
- This is a very simple implementation of the touch command. It does not support all the options that the Linux touch command supports.