#pragma checksum "C:\Users\walbe\Documents\GitHub\Mantenimiento_NetCore\Mantenimiento\Mantenimiento\Areas\Mantenimiento\Views\MantenimientoApi\_CrudBaseForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d2d3d308d839d5993fb8c8174c8e3a5386bf1e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Mantenimiento_Views_MantenimientoApi__CrudBaseForm), @"mvc.1.0.view", @"/Areas/Mantenimiento/Views/MantenimientoApi/_CrudBaseForm.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d2d3d308d839d5993fb8c8174c8e3a5386bf1e2", @"/Areas/Mantenimiento/Views/MantenimientoApi/_CrudBaseForm.cshtml")]
    public class Areas_Mantenimiento_Views_MantenimientoApi__CrudBaseForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Mantenimiento.Models.DTO.CrudBaseDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"modal-header\">\r\n    <h4>Formulario</h4>\r\n</div>\r\n<div class=\"modal-body\">\r\n    <form id=\"formMantenimiento\">\r\n        ");
#nullable restore
#line 8 "C:\Users\walbe\Documents\GitHub\Mantenimiento_NetCore\Mantenimiento\Mantenimiento\Areas\Mantenimiento\Views\MantenimientoApi\_CrudBaseForm.cshtml"
   Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 10 "C:\Users\walbe\Documents\GitHub\Mantenimiento_NetCore\Mantenimiento\Mantenimiento\Areas\Mantenimiento\Views\MantenimientoApi\_CrudBaseForm.cshtml"
       Write(Html.LabelFor(x => x.Codigo, "C??digo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 11 "C:\Users\walbe\Documents\GitHub\Mantenimiento_NetCore\Mantenimiento\Mantenimiento\Areas\Mantenimiento\Views\MantenimientoApi\_CrudBaseForm.cshtml"
       Write(Html.TextBoxFor(x => x.Codigo, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 14 "C:\Users\walbe\Documents\GitHub\Mantenimiento_NetCore\Mantenimiento\Mantenimiento\Areas\Mantenimiento\Views\MantenimientoApi\_CrudBaseForm.cshtml"
       Write(Html.LabelFor(x => x.Descripcioncorta, "Descripci??n Corta"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 15 "C:\Users\walbe\Documents\GitHub\Mantenimiento_NetCore\Mantenimiento\Mantenimiento\Areas\Mantenimiento\Views\MantenimientoApi\_CrudBaseForm.cshtml"
       Write(Html.TextBoxFor(x => x.Descripcioncorta, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 18 "C:\Users\walbe\Documents\GitHub\Mantenimiento_NetCore\Mantenimiento\Mantenimiento\Areas\Mantenimiento\Views\MantenimientoApi\_CrudBaseForm.cshtml"
       Write(Html.LabelFor(x => x.Descripcionlarga, "Descripci??n Larga"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 19 "C:\Users\walbe\Documents\GitHub\Mantenimiento_NetCore\Mantenimiento\Mantenimiento\Areas\Mantenimiento\Views\MantenimientoApi\_CrudBaseForm.cshtml"
       Write(Html.TextBoxFor(x => x.Descripcionlarga, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 21 "C:\Users\walbe\Documents\GitHub\Mantenimiento_NetCore\Mantenimiento\Mantenimiento\Areas\Mantenimiento\Views\MantenimientoApi\_CrudBaseForm.cshtml"
         if (Model.Id != 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 24 "C:\Users\walbe\Documents\GitHub\Mantenimiento_NetCore\Mantenimiento\Mantenimiento\Areas\Mantenimiento\Views\MantenimientoApi\_CrudBaseForm.cshtml"
           Write(Html.LabelFor(x => x.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 25 "C:\Users\walbe\Documents\GitHub\Mantenimiento_NetCore\Mantenimiento\Mantenimiento\Areas\Mantenimiento\Views\MantenimientoApi\_CrudBaseForm.cshtml"
           Write(Html.CheckBoxFor(x => x.Estado, new { @class = "form-check", @type = "checkbox" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 27 "C:\Users\walbe\Documents\GitHub\Mantenimiento_NetCore\Mantenimiento\Mantenimiento\Areas\Mantenimiento\Views\MantenimientoApi\_CrudBaseForm.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </form>
</div>
<div class=""modal-footer"">
    <div style=""text-align:end"">
        <button type=""button"" class=""btn btn-success"" onclick=""ValidateForm()"">Guardar</button>
        <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Cancelar</button>
    </div>
</div>

<script>
    var formMantenimiento = $(""#formMantenimiento"");

    formMantenimiento.validate({
        ignore: [],
        rules: {
            'Codigo': {
                required: true
            },
            'Descripcioncorta': {
                required: true
            },
            'Descripcionlarga': {
                required: true
            }
        },
        messages: {
            'Codigo': {
                required: ""El campo C??digo es requerido.""
            },
            'Descripcioncorta': {
                required: ""El campo Descripci??n Corta es requerido.""
            },
            'Descripcionlarga': {
                required: ""El campo Descripci??n Larga es requer");
            WriteLiteral(@"ido.""
            }
        },
        errorPlacement: function (error, element) {
    		if(element.hasClass('select2') && element.next('.select2-container').length) {
        	error.insertAfter(element.next('.select2-container'));
            } else if (element.parent('.input-group').length) {
                error.insertAfter(element.parent());
            }
            else if (element.prop('type') === 'radio' && element.parent('.radio-inline').length) {
                error.insertAfter(element.parent().parent());
            }
            else if (element.prop('type') === 'checkbox' || element.prop('type') === 'radio') {
                error.appendTo(element.parent().parent());
            }
            else {
                error.insertAfter(element);
            }
        },
        errorClass: ""my-error-class"",
        validClass: ""my-valid-class""
    });

    $(window).keydown(function (event) {
        if (event.keyCode === 13) {
            event.preventDefault();
      ");
            WriteLiteral("      //AjaxSubmit();\r\n            return false;\r\n        }\r\n    });\r\n\r\n    function ValidateForm() {\r\n        if (formMantenimiento.valid()) AjaxSubmit();\r\n    }\r\n\r\n    function AjaxSubmit() {\r\n        $.ajax({\r\n            url: \"");
#nullable restore
#line 98 "C:\Users\walbe\Documents\GitHub\Mantenimiento_NetCore\Mantenimiento\Mantenimiento\Areas\Mantenimiento\Views\MantenimientoApi\_CrudBaseForm.cshtml"
             Write(Url.Action("Guardar", "MantenimientoApi", new { area = "Mantenimiento" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            type: ""POST"",
            dataType: ""JSON"",
            data: formMantenimiento.serialize(),
            beforeSend: function () {
                //$('#ibox1').children('.ibox-content').toggleClass('sk-loading');
            },
            complete: function () {
                //$('#ibox1').children('.ibox-content').toggleClass('sk-loading');
            },
            success: function (data) {
                console.log(data)
                var success = data.result;
                var message = data.message;
                if (success == true) {
                    $(""#nuevoRegistroModal"").modal('hide');
                    loadDataTableCruds();
                    toastr.success(message, 'Correcto!')
                }
                else {
                    toastr.error(message, 'Error!')
                }
            },
            error: function (data) {
                toastr.error(""Error de conexi??n con el servidor."", 'Error!')
            }
        ");
            WriteLiteral("});\r\n    }\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mantenimiento.Models.DTO.CrudBaseDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
