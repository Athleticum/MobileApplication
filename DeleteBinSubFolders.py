import platform
import os
import shutil
import glob

for filename in glob.iglob('**/bin/**', recursive=True):
    if not filename.endswith("\\bin\\"):
        if not os.path.isfile(filename):
            print(filename)
            shutil.rmtree(filename)
    
