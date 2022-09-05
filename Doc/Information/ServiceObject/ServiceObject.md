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
|severity|**en**: severity||0-1|||True|
|status|**en**: status||0-1|||True|

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|acknowledgedTime|**en**: acknowledged time||dateTime|True|
|closedTime|**en**: closed time||dateTime|True|
|createdTime|**en**: created time||dateTime|True|
### Inherited Properties
* **[Information](../Information.md):** customTags, externalIds, name

---

## Target Of
