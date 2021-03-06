﻿using Microsoft.AspNetCore.Mvc;

namespace YA.ServiceTemplate.Application.Models.Dto
{
    public class ApiProblemDetails : ProblemDetails
    {
        public ApiProblemDetails(string type, int? status, string instance, string title, string detail, string correlationId, string traceId = null)
        {
            Type = type;
            Status = status;
            Instance = instance;
            Title = title;
            Detail = detail;
            CorrelationId = correlationId;
            TraceId = traceId;
        }

        public string CorrelationId { get; private set; }
        public string TraceId { get; private set; }
    }
}