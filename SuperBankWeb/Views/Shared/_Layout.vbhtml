<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>SuperBank</title>
    <link type="text/css" rel="stylesheet" href="~/Content/Site.css" />
</head>
<body>
    <div class="header">
        <a class="logo" href="/">&nbsp;</a>
        <ul>
            <li><a href="/">Home</a></li>
            <li><a href="/?Page=About">About us</a></li>
        </ul>
    </div>
    <div class="body">
        @RenderBody()
    </div>
    <div class="footer">
        <hr />
        <h3>Important documents</h3>
        <ul>
            <li><a href="/Download?File=Terms and conditions.pdf">Terms and conditions</a></li>
            <li><a href="/Download?File=Security checklist.pdf">Security checklist</a></li>
        </ul>
    </div>
</body>
</html>
