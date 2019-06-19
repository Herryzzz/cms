﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection.Extensions;
using SS.CMS.Core.Repositories;
using SS.CMS.Core.Services;
using SS.CMS.Repositories;
using SS.CMS.Services.ICacheManager;
using SS.CMS.Services.ICreateManager;
using SS.CMS.Services.IFileManager;
using SS.CMS.Services.IPathManager;
using SS.CMS.Services.IPluginManager;
using SS.CMS.Services.ISettingsManager;
using SS.CMS.Services.ITableManager;
using SS.CMS.Services.IUrlManager;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static ISettingsManager AddSettingsManager(this IServiceCollection services, IConfiguration configuration, string contentRootPath, string webRootPath)
        {
            var settingsManager = new SettingsManager(configuration, contentRootPath, webRootPath);
            services.TryAdd(ServiceDescriptor.Singleton<ISettingsManager>(settingsManager));

            return settingsManager;
        }

        public static IServiceCollection AddCacheManager(this IServiceCollection services)
        {
            services.TryAdd(ServiceDescriptor.Singleton<ICacheManager, CacheManager>());

            return services;
        }

        public static IServiceCollection AddUrlManager(this IServiceCollection services)
        {
            services.TryAdd(ServiceDescriptor.Singleton<IUrlManager, UrlManager>());

            return services;
        }

        public static IServiceCollection AddPathManager(this IServiceCollection services)
        {
            services.TryAdd(ServiceDescriptor.Singleton<IPathManager, PathManager>());

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.TryAdd(ServiceDescriptor.Transient<IAccessTokenRepository, AccessTokenRepository>());
            services.TryAdd(ServiceDescriptor.Transient<IAreaRepository, AreaRepository>());
            services.TryAdd(ServiceDescriptor.Transient<IChannelGroupRepository, ChannelGroupRepository>());
            services.TryAdd(ServiceDescriptor.Transient<IChannelRepository, ChannelRepository>());
            services.TryAdd(ServiceDescriptor.Transient<IConfigRepository, ConfigRepository>());
            services.TryAdd(ServiceDescriptor.Transient<IContentCheckRepository, ContentCheckRepository>());
            services.TryAdd(ServiceDescriptor.Transient<IContentGroupRepository, ContentGroupRepository>());
            services.TryAdd(ServiceDescriptor.Transient<IDbCacheRepository, DbCacheRepository>());
            services.TryAdd(ServiceDescriptor.Transient<IDepartmentRepository, DepartmentRepository>());
            services.TryAdd(ServiceDescriptor.Transient<IErrorLogRepository, ErrorLogRepository>());
            services.TryAdd(ServiceDescriptor.Transient<ILogRepository, LogRepository>());
            services.TryAdd(ServiceDescriptor.Transient<IPermissionRepository, PermissionRepository>());
            services.TryAdd(ServiceDescriptor.Transient<IPluginConfigRepository, PluginConfigRepository>());
            services.TryAdd(ServiceDescriptor.Transient<IPluginRepository, PluginRepository>());
            services.TryAdd(ServiceDescriptor.Transient<IRelatedFieldItemRepository, RelatedFieldItemRepository>());
            services.TryAdd(ServiceDescriptor.Transient<IRelatedFieldRepository, RelatedFieldRepository>());
            services.TryAdd(ServiceDescriptor.Transient<IRoleRepository, RoleRepository>());
            services.TryAdd(ServiceDescriptor.Transient<ISiteLogRepository, SiteLogRepository>());
            services.TryAdd(ServiceDescriptor.Transient<ISiteRepository, SiteRepository>());
            services.TryAdd(ServiceDescriptor.Transient<ISpecialRepository, SpecialRepository>());
            services.TryAdd(ServiceDescriptor.Transient<ITableStyleItemRepository, TableStyleItemRepository>());
            services.TryAdd(ServiceDescriptor.Transient<ITableStyleRepository, TableStyleRepository>());
            services.TryAdd(ServiceDescriptor.Transient<ITagRepository, TagRepository>());
            services.TryAdd(ServiceDescriptor.Transient<ITemplateLogRepository, TemplateLogRepository>());
            services.TryAdd(ServiceDescriptor.Transient<ITemplateRepository, TemplateRepository>());
            services.TryAdd(ServiceDescriptor.Transient<IUserGroupRepository, UserGroupRepository>());
            services.TryAdd(ServiceDescriptor.Transient<IUserLogRepository, UserLogRepository>());
            services.TryAdd(ServiceDescriptor.Transient<IUserMenuRepository, UserMenuRepository>());
            services.TryAdd(ServiceDescriptor.Transient<IUserRepository, UserRepository>());
            services.TryAdd(ServiceDescriptor.Transient<IUserRoleRepository, UserRoleRepository>());

            return services;
        }

        public static IServiceCollection AddFileManager(this IServiceCollection services)
        {
            services.TryAdd(ServiceDescriptor.Singleton<IFileManager, FileManager>());

            return services;
        }

        public static IServiceCollection AddCreateManager(this IServiceCollection services)
        {
            services.TryAdd(ServiceDescriptor.Singleton<ICreateManager, CreateManager>());

            return services;
        }

        public static IServiceCollection AddPluginManager(this IServiceCollection services)
        {
            services.TryAdd(ServiceDescriptor.Singleton<IPluginManager, PluginManager>());

            return services;
        }

        public static IServiceCollection AddTableManager(this IServiceCollection services)
        {
            services.TryAdd(ServiceDescriptor.Singleton<ITableManager, TableManager>());

            return services;
        }
    }
}