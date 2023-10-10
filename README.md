# itf

IGN Tif file Filter - Experimental tool

This console tool filters the files within in bounding box, to speed up processing.

IGN files with DEM"S come in huge compressed zips. It contains files like RGEALTI_FXX_0276_6717_DST_LAMB93_IGN69.tif

The tools splits the filename on '_' and takes the number 2 and 3 item (276 and 6717) and compares to the specified bounding box.

Warning: File outside bounding box are deleted so make backups

