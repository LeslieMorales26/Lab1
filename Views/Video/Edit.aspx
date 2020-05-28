<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Edit</title>
</head>
<body>
    <form action="/Video/Edit" method="post">
    <fieldset>

    <legend>Informacion del Video</legend>
    <label for ="idVideo">idVideo</label>
    <input type="text" name="idVideo" />

    <label for ="titulo">titulo</label>
    <input type="text" name="titulo" />

    <label for ="repro">repro</label>
    <input type="text" name="repro" />

    <label for ="url">url</label>
    <input type="text" name = "url" />
    <br />
    <input type="submit" value= "Actualizar" />

    </fieldset>
    </form>
</body>
</html>
