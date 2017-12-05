import platform
import os
import shutil
import glob

for filename in glob.iglob('**/obj', recursive=True):
    shutil.rmtree(filename)
    
