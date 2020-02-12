@ModelType Models.Article

<h1>@Model.Title</h1>

<div>
    @Html.Raw(Model.Text)
</div>
