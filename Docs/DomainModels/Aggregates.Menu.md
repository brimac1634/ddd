# Domain Models

## Menu

```csharp
class Menu
{
    Menu Create();
    void AddDinner(Dinner dinner);
    void RemoveDinner(Dinner dinner);
    void UpdateSection(MenuSection section);
}
```

```json
{
    "id": "0000-000-0000-00000",
    "name": "Yummy Menu",
    "description": "This is a yummy menu",
    "averageRating": 4.5,
    "sections": [
        {
            "id": "0000-000-0000-00000",
            "name": "Appetizers",
            "description": "This is a yummy starter",
            "items": [
                {
                    "id": "0000-000-0000-00000",
                    "name": "Yummy Item",
                    "description": "This is a yummy item",
                    "price": 5.50,
                }
            ]
        }
    ],
    "createdDateTime": "0000-00-00T00:00:00.000Z",
    "updatedDateTime": "0000-00-00T00:00:00.000Z",
    "hostId": "0000-000-0000-00000",
    "dinnerIds": [
        "0000-000-0000-00000",
    ],
    "menuReviewIds": [
        "0000-000-0000-00000",
    ]
}
```