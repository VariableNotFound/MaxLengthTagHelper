# MaxLengthTagHelper
An ASP.NET Core MVC Tag Helper for automatically adding 'maxlength' attribute to input tags, based on model annotations.

## Usage

1. Include the class [MaxLengthTagHelper](src/MaxLengthTagHelperDemo/TagHelpers/MaxLengthTagHelper.cs) in your project.
2. Add the following directive to the view where you are going to use the tag helper, or in `Views/ViewImports.cshtml` if you wish to make it available to all the views in the project:

      ```cshtml
      @addTagHelper *, YourProjectAssemblyName
      ```

## Example

### View model class:
```cs
public class PersonViewModel
{
    [Required, StringLength(25), Display(Name = "First name")]
    public string FirstName { get; set; }

    [Required, MaxLength(50), Display(Name = "Last name")]
    public string LastName { get; set; }

    [EmailAddress, MaxLength(200), Display(Name = "Email address")]
    public string Email { get; set; }
}
```
### View:
```cshtml
@model PersonViewModel
@addTagHelper *, MaxLengthTagHelperDemo

<h1>Edit person</h1>
<form asp-action="Edit" method="post">
    <div class="form-group">
        <label asp-for="FirstName"></label>
        <input asp-for="FirstName" class="form-control" />
    </div>
    <div class="form-group">
        <label asp-for="LastName"></label>
        <input asp-for="LastName" class="form-control" />
    </div>
    <div class="form-group">
        <label asp-for="Email"></label>
        <input asp-for="Email" class="form-control" maxlength="180" /> <!-- Hey, maxlength overriden here! -->
    </div>
    <div class="form-group">
        <button type="submit" class="btn btn-primary">Save changes</button>
    </div>
</form>
```
### HTML sent to the client (simplified):
```html
<form method="post" action="/">
    <div class="form-group">
        <label for="FirstName">First name</label>
        <input class="form-control" type="text" id="FirstName" name="FirstName" value="" maxlength="25" />
    </div>
    <div class="form-group">
        <label for="LastName">Last name</label>
        <input class="form-control" type="text" id="LastName" name="LastName" value="" maxlength="50" />
    </div>
    <div class="form-group">
        <label for="Email">Email address</label>
        <input class="form-control" type="email" id="Email" name="Email" value="" maxlength="180" />
    </div>
    <div class="form-group">
        <button type="submit" class="btn btn-primary">Save changes</button>
    </div>
</form>
```
