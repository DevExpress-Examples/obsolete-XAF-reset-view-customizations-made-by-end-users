#DropDB E1897
#Application E1897Win

*CheckTable
 Columns = Text
 Row = test

*Action Test
!ProcessRecord
 Text = test
*Action Reset View Settings
*CheckTable
 Columns = Text
 Row = test
*ProcessRecord 
 Text = test
*FieldVisible Text
*Action Test
*Sleep 1000
!FieldVisible Text
*Action Reset View Settings
*FieldVisible Text
*Action Save and New
!ActionAvailable Reset View Settings
*Action Save
*ActionAvailable Reset View Settings