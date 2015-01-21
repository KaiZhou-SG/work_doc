#!/bin/bash
cp -urvf /cygdrive/d/workLog/static/fm85_20140922/MS_Simulator/* /cygdrive/d/workLog/static/projects/work_doc/simulator_codes/

find /cygdrive/d/workLog/static/projects/work_doc/simulator_codes/ -iname "*.exe" -delete
find /cygdrive/d/workLog/static/projects/work_doc/simulator_codes/ -iname "*.pdb" -delete
find /cygdrive/d/workLog/static/projects/work_doc/simulator_codes/ -iname "*.vshost*" -delete
find /cygdrive/d/workLog/static/projects/work_doc/simulator_codes/ -iname "*.config" -delete
find /cygdrive/d/workLog/static/projects/work_doc/simulator_codes/ -iname "*.xml" -delete
