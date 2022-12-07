[Index](../../index.md) > [Information](../Information.md) > [ServiceObject](#)
# ServiceObject

**Display name:** Service object<br />
**DTMI:** dtmi:org:w3id:rec:ServiceObject;1

---

## Child interfaces
* [AlarmObject](AlarmObject.md)
* [ErrorReport](ErrorReport.md)
* [NotificationObject](NotificationObject.md)
* [WorkOrder](WorkOrder.md)

---

## Relationships

|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|acknowledgedBy|**en**: acknowledged by||0-1|[Agent](../../Agent/Agent.md)||True|
|closedBy|**en**: closed by||0-1|[Agent](../../Agent/Agent.md)||True|
|createdBy|**en**: created by||0-1|[Agent](../../Agent/Agent.md)||True|
|producedBy|**en**: produced by||0-Infinity|[Point](../../Point/Point.md)||True|
|relatedTo|**en**: related to||0-Infinity|||True|

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|acknowledgedTime|**en**: acknowledged time||dateTime|True|
|closedTime|**en**: closed time||dateTime|True|
|createdTime|**en**: created time||dateTime|True|
|severity|**en**: severity||enum (Major, Minor, Severe)|True|
|status|**en**: status||enum (Acknowledged, Closed, Unacknowledged)|True|
### Inherited Properties
* **[Information](../Information.md):** customProperties, customTags, identifiers, name

---

## Target Of
### General
* [Point](../../Point/Point.md).isPointOf
* [Agent](../../Agent/Agent.md).owns
* [Space](../../Space/Space.md).isLocationOf
* [Equipment](../../Asset/Equipment/Equipment.md).feeds
* [Equipment](../../Asset/Equipment/Equipment.md).isFedBy
* [Architecture](../../Space/Architecture/Architecture.md).isFedBy
* [Document](../Document/Document.md).documentTopic
* [Document](../Document/Document.md).url
* [EquipmentCollection](../../Collection/Equipment-.md).feeds
* [Lease](../../Event/Lease.md).leaseOf
* [PointOfInterest](../PointOfInterest.md).objectOfInterest
* [Portfolio](../../Collection/Portfolio.md).includes
* [ServiceObject](#).relatedTo
* [Meter](../../Asset/Equipment/Meter/Meter.md).meters
