# Pythonnet Memleak by Exception

This repository functions as sample to reproduce a memory leak in pythonnet by throwing exception from .NET and catching them in python.

## Usage

First open the solution and compile the project. It should work out of the box (.NET Framework 4.7.2).

Then navigate to the `Python/` directory and execute the main script.

```bash
cd <path/to/repo>/Python/
python3 main.py
```

Note that of course you have to use a python environment where pythonnet is installed.