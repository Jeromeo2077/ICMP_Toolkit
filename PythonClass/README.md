# PythonClass

This folder is set up to support **both**:
- Running `.py` scripts
- Running Jupyter notebooks (`.ipynb`) in VS Code

## One-time setup

### 1) Open this folder in VS Code
Open the `PythonClass` folder as its own workspace (recommended), or keep it as a subfolder inside your existing workspace.

### 2) Create a virtual environment
In a VS Code terminal (PowerShell):

```powershell
python -m venv .venv
```

### 3) Install notebook support into the venv

```powershell
.\.venv\Scripts\python -m pip install -U pip
.\.venv\Scripts\python -m pip install -r requirements.txt
```

### 4) Select the interpreter
In VS Code:
- `Ctrl+Shift+P` → **Python: Select Interpreter** → choose `.venv`

## Run a script

```powershell
.\.venv\Scripts\python .\src\hello.py
```

## Run the notebook
Open `notebooks/Lesson_01.ipynb` and choose the kernel that points to `.venv`.
