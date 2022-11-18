using Tema_GDSC;

Constructor builder = new Constructor();
Admin admin = builder.BuildAdmin();


WebApplication webApplication = new WebApplication("Web");
MobileApplication mobileApplication = new MobileApplication("Mobile");

admin.AddApplications(webApplication);
admin.AddApplications(mobileApplication);

User us = new User("Nikita", "*******", "nb@studnet.upt.ro");

admin.AddUser(us, webApplication);

webApplication.HttpRequest(us);
admin.RemoveUser(us, webApplication);
webApplication.HttpRequest(us);