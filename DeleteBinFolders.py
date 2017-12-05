import platform
import os
import shutil
import glob

for filename in glob.iglob('**/bin', recursive=True):
    shutil.rmtree(filename)
    
