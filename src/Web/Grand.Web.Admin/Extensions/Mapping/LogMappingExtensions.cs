﻿using Grand.Domain.Logging;
using Grand.Infrastructure.Mapper;
using Grand.Web.Admin.Models.Logging;

namespace Grand.Web.Admin.Extensions.Mapping
{
    public static class LogMappingExtensions
    {
        public static LogModel ToModel(this Log entity)
        {
            return entity.MapTo<Log, LogModel>();
        }

        public static Log ToEntity(this LogModel model)
        {
            return model.MapTo<LogModel, Log>();
        }

        public static Log ToEntity(this LogModel model, Log destination)
        {
            return model.MapTo(destination);
        }

        public static ActivityLogTypeModel ToModel(this ActivityLogType entity)
        {
            return entity.MapTo<ActivityLogType, ActivityLogTypeModel>();
        }

        public static ActivityLogModel ToModel(this ActivityLog entity)
        {
            return entity.MapTo<ActivityLog, ActivityLogModel>();
        }

        public static ActivityStatsModel ToModel(this ActivityStats entity)
        {
            return entity.MapTo<ActivityStats, ActivityStatsModel>();
        }
    }
}