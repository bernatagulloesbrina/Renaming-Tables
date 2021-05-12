string oldName = "Dim Calendario";
string newName = "Fecha"; 

int oldNameIndex = 0; 
int newNameIndex = 1; 


string[,] replaceOldNew = 
    {
        {"Dim Calendario","Fecha"},
        {"Dim Año","Año"}
    };

for(int i = 0; i < replaceOldNew.GetLength(0); i++) {
    
    oldName = replaceOldNew[i,oldNameIndex];
    newName = replaceOldNew[i,newNameIndex];
    
    foreach(var t in Model.Tables){
        t.Name = t.Name.Replace(oldName, newName);
    };

    foreach (var t in Model.Tables.OfType<CalculatedTable>()) {
       t.Expression = t.Expression.Replace(oldName,newName); 
    };

};
