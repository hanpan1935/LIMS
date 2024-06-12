using System;
using System.ComponentModel;
using Volo.Abp.Application.Dtos;

namespace Lanpuda.Lims.Maintenances.Dtos;

[Serializable]
public class MaintenanceGetListInput : PagedAndSortedResultRequestDto
{
    /// <summary>
    /// 
    /// </summary>
    [DisplayName("MaintenanceNumber")]
    public string? Number { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [DisplayName("MaintenanceEquipmentId")]
    public Guid? EquipmentId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [DisplayName("MaintenanceDate")]
    public DateTime? DateStart { get; set; }


    public DateTime? DateEnd { get; set; }

   
    [DisplayName("MaintenanceMaintenanceType")]
    public MaintenanceType? MaintenanceType { get; set; }

    //ά���������¼ά���Ľ��������ά����ɡ�ά��������ɵȡ�
    public MaintenanceResult? Result { get; set; }
}