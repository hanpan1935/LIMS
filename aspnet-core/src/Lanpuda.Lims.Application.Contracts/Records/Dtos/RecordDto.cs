using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Lanpuda.Lims.Records.Dtos;

/// <summary>
/// 
/// </summary>
[Serializable]
public class RecordDto : LimsAuditedEntityDto<Guid>
{
    /// <summary>
    /// 
    /// </summary>
    public string Number { get; set; }

    public int? DicRatingTypeId { get; set; }
    public string? DicRatingTypeDisplayValue { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Remark { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Guid SampleId { get; set; }
    public string SampleNumber { get; set; }

    public string? ProductName { get; set; }


    public int? DicSampleTypeId { get; set; }
    public string? DicSampleTypeDisplayValue { get; set; }

    public int? DicSamplePropertyId { get; set; }
    public string? DicSamplePropertyDisplayValue { get; set; }

    //����ʱ��
    public DateTime? SampleTime { get; set; }

    //��������
    public DateTime? ExpireTime { get; set; }

    //��Ʒ����
    public double? SampleCount { get; set; }

    //������
    public string? Sender { get; set; }

    public Guid? CustomerId { get; set; }
    public string? CustomerFullName { get; set; }
    public string? CustomerShortName { get; set; }

    public Guid? SupplierId { get; set; }
    public string? SupplierFullName { get; set; }
    public string? SupplierShortName { get; set; }





    /// 
    /// </summary>
    public List<RecordDetailDto> Details { get; set; }
}