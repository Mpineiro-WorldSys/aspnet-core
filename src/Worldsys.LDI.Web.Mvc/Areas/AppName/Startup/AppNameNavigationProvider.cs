using Abp.Application.Navigation;
using Abp.Authorization;
using Abp.Localization;
using Worldsys.LDI.Authorization;

namespace Worldsys.LDI.Web.Areas.AppName.Startup
{
    public class AppNameNavigationProvider : NavigationProvider
    {
        public const string MenuName = "App";

        public override void SetNavigation(INavigationProviderContext context)
        {
            var menu = context.Manager.Menus[MenuName] = new MenuDefinition(MenuName, new FixedLocalizableString("Main Menu"));

            menu
                .AddItem(new MenuItemDefinition(
                        AppNamePageNames.Host.Dashboard,
                        L("Dashboard"),
                        url: "AppName/HostDashboard",
                        icon: "flaticon-line-graph",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Host_Dashboard)
                    )
                ).AddItem(new MenuItemDefinition(
                    AppNamePageNames.Host.Tenants,
                    L("Tenants"),
                    url: "AppName/Tenants",
                    icon: "flaticon-list-3",
                    permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Tenants)
                    )
                ).AddItem(new MenuItemDefinition(
                        AppNamePageNames.Host.Editions,
                        L("Editions"),
                        url: "AppName/Editions",
                        icon: "flaticon-app",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Editions)
                    )
                ).AddItem(new MenuItemDefinition(
                        AppNamePageNames.Tenant.Dashboard,
                        L("Dashboard"),
                        url: "AppName/TenantDashboard",
                        icon: "flaticon-line-graph",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Tenant_Dashboard)
                    )
                ).AddItem(new MenuItemDefinition(
                        AppNamePageNames.Common.Administration,
                        L("Administration"),
                        icon: "flaticon-interface-8"
                    ).AddItem(new MenuItemDefinition(
                            AppNamePageNames.Common.OrganizationUnits,
                            L("OrganizationUnits"),
                            url: "AppName/OrganizationUnits",
                            icon: "flaticon-map",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_OrganizationUnits)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppNamePageNames.Common.Roles,
                            L("Roles"),
                            url: "AppName/Roles",
                            icon: "flaticon-suitcase",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Roles)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppNamePageNames.Common.Users,
                            L("Users"),
                            url: "AppName/Users",
                            icon: "flaticon-users",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Users)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppNamePageNames.Common.Languages,
                            L("Languages"),
                            url: "AppName/Languages",
                            icon: "flaticon-tabs",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Languages)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppNamePageNames.Common.AuditLogs,
                            L("AuditLogs"),
                            url: "AppName/AuditLogs",
                            icon: "flaticon-folder-1",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_AuditLogs)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppNamePageNames.Host.Maintenance,
                            L("Maintenance"),
                            url: "AppName/Maintenance",
                            icon: "flaticon-lock",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Host_Maintenance)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppNamePageNames.Tenant.SubscriptionManagement,
                            L("Subscription"),
                            url: "AppName/SubscriptionManagement",
                            icon: "flaticon-refresh",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Tenant_SubscriptionManagement)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppNamePageNames.Common.UiCustomization,
                            L("VisualSettings"),
                            url: "AppName/UiCustomization",
                            icon: "flaticon-medical",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_UiCustomization)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AppNamePageNames.Common.WebhookSubscriptions,
                            L("WebhookSubscriptions"),
                            url: "AppName/WebhookSubscription",
                            icon: "flaticon2-world",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_WebhookSubscription)
                        )
                    )
                    .AddItem(new MenuItemDefinition(
                            AppNamePageNames.Common.DynamicProperties,
                            L("DynamicProperties"),
                            url: "AppName/DynamicProperty",
                            icon: "flaticon-interface-8",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_DynamicProperties)
                        )
                    )
                    .AddItem(new MenuItemDefinition(
                            AppNamePageNames.Host.Settings,
                            L("Settings"),
                            url: "AppName/HostSettings",
                            icon: "flaticon-settings",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Host_Settings)
                        )
                    )
                    .AddItem(new MenuItemDefinition(
                            AppNamePageNames.Tenant.Settings,
                            L("Settings"),
                            url: "AppName/Settings",
                            icon: "flaticon-settings",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Tenant_Settings)
                        )
                    )
                ).AddItem(new MenuItemDefinition(
                        AppNamePageNames.Common.DemoUiComponents,
                        L("DemoUiComponents"),
                        url: "AppName/DemoUiComponents",
                        icon: "flaticon-shapes",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_DemoUiComponents)
                    )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, LDIConsts.LocalizationSourceName);
        }
    }
}
