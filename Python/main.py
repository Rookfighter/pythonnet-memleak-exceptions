import os
import sys
import __main__

import clr

bin_dir = os.path.abspath(os.path.join(os.path.dirname(__main__.__file__), '../Source/LeakingExceptions/bin/Debug'))
clr.AddReference(os.path.join(bin_dir, 'LeakingExceptions'))

from LeakingExceptions import ExceptionThrower

thrower = ExceptionThrower()

while True:
    try:
        thrower.ThrowException()
    except:
        pass