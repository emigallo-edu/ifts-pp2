// Cada paso es un refactor: cambia los nombres, no lo que el programa hace.
// Este programa es la red de seguridad: ejecuta todos los pasos con los mismos datos y compara la salida con la del código inicial.

var registros = new (string Comision, int Legajo, int Inasistencias, int TrabajosNoEntregados)[]
{
    ("1°A", 1001, 4, 0),  // 25% de inasistencias: en riesgo
    ("1°A", 1002, 1, 2),  // dos trabajos sin entregar: en riesgo
    ("1°A", 1003, 3, 1),  // 18% y un trabajo sin entregar: no está en riesgo
    ("1°B", 2001, 6, 0),
    ("1°B", 2002, 0, 0),
    ("2°A", 3001, 2, 1),
};

var comisiones = registros.GroupBy(r => r.Comision);

string Paso0()
{
    var resumenes = new List<string>();
    foreach (var comision in comisiones)
    {
        var datos = new App.Paso0.DatosMgr(comision.Key);
        foreach (var r in comision) datos.Add(r.Legajo, r.Inasistencias, r.TrabajosNoEntregados);
        resumenes.Add(datos.Proc());
    }
    return string.Join("\n", resumenes);
}

string Paso1()
{
    var resumenes = new List<string>();
    foreach (var comision in comisiones)
    {
        var datos = new App.Paso1.DatosMgr(comision.Key);
        foreach (var r in comision) datos.Add(r.Legajo, r.Inasistencias, r.TrabajosNoEntregados);
        resumenes.Add(datos.Proc());
    }
    return string.Join("\n", resumenes);
}

string Paso2()
{
    var resumenes = new List<string>();
    foreach (var comision in comisiones)
    {
        var datos = new App.Paso2.DatosMgr(comision.Key);
        foreach (var r in comision) datos.Add(r.Legajo, r.Inasistencias, r.TrabajosNoEntregados);
        resumenes.Add(datos.Proc());
    }
    return string.Join("\n", resumenes);
}

string Paso3()
{
    var resumenes = new List<string>();
    foreach (var comision in comisiones)
    {
        var datos = new App.Paso3.DatosMgr(comision.Key);
        foreach (var r in comision) datos.Registrar(r.Legajo, r.Inasistencias, r.TrabajosNoEntregados);
        resumenes.Add(datos.Proc());
    }
    return string.Join("\n", resumenes);
}

string Paso4()
{
    var resumenes = new List<string>();
    foreach (var comision in comisiones)
    {
        var datos = new App.Paso4.DatosMgr(comision.Key);
        foreach (var r in comision) datos.Registrar(r.Legajo, r.Inasistencias, r.TrabajosNoEntregados);
        resumenes.Add(datos.Proc());
    }
    return string.Join("\n", resumenes);
}

string Paso5()
{
    var resumenes = new List<string>();
    foreach (var grupo in comisiones)
    {
        var comision = new App.Paso5.Comision(grupo.Key);
        foreach (var r in grupo) comision.Registrar(r.Legajo, r.Inasistencias, r.TrabajosNoEntregados);
        resumenes.Add(comision.ResumenDeRiesgo());
    }
    return string.Join("\n", resumenes);
}

string Paso6()
{
    var resumenes = new List<string>();
    foreach (var grupo in comisiones)
    {
        var comision = new App.Paso6.Comision(grupo.Key);
        foreach (var r in grupo) comision.Registrar(r.Legajo, r.Inasistencias, r.TrabajosNoEntregados);
        resumenes.Add(comision.ResumenDeRiesgo());
    }
    return string.Join("\n", resumenes);
}

string esperado = Paso0();
Console.WriteLine(esperado);
Console.WriteLine();

var pasos = new (string Nombre, Func<string> Ejecutar)[]
{
    ("Paso 1", Paso1), ("Paso 2", Paso2), ("Paso 3", Paso3),
    ("Paso 4", Paso4), ("Paso 5", Paso5), ("Paso 6", Paso6),
};

foreach (var paso in pasos)
    Console.WriteLine($"{paso.Nombre}: {(paso.Ejecutar() == esperado ? "misma salida" : "LA SALIDA CAMBIÓ")}");
