# Serialization Refactoring

## Overview

The codebase has been refactored to use proper serialization with a unified `SaveGameSerializer` class that replaces the separate `DataReader` and `DataWriter` classes. This refactoring provides better maintainability, reduces code duplication, and offers a cleaner API.

## Before the Refactoring

### Old Approach Problems:
- **Manual serialization**: Each property was manually read/written in `DataReader` and `DataWriter`
- **Code duplication**: Similar logic existed in both reader and writer classes
- **Maintenance burden**: Adding new properties required updating both classes
- **Error-prone**: Manual handling of each field could lead to inconsistencies
- **Format-specific**: Separate handling for binary and JSON formats

### Old Usage:
```csharp
// Reading
Player player = DataReader.ReadFromFile(filePath, console);

// Writing
var writer = new DataWriter(player);
writer.WriteToFile(filePath);

// JSON was handled separately
JsonHandler.SaveGameToJson(player, jsonFilePath);
```

## After the Refactoring

### New Approach Benefits:
- **Unified API**: Single class handles both binary and JSON formats
- **Attribute-based**: `BinaryOrder` attributes control serialization order
- **Reflection-based**: Automatic serialization using reflection
- **Type-safe**: Compile-time checking of property types
- **Maintainable**: Adding new properties only requires adding the attribute
- **Extensible**: Easy to add new formats in the future

### New Usage:
```csharp
// Binary operations
Player player = SaveGameSerializer.LoadFromBinary(filePath, console);
SaveGameSerializer.SaveToBinary(player, filePath);

// JSON operations
Player playerFromJson = SaveGameSerializer.LoadFromJson(jsonFilePath);
SaveGameSerializer.SaveToJson(player, jsonFilePath);

// Format conversion
Player player = SaveGameSerializer.LoadFromBinary(binaryPath, console);
SaveGameSerializer.SaveToJson(player, jsonPath);
```

## Key Components

### 1. SaveGameSerializer Class
- `LoadFromBinary(string filePath, ITextBoxWrapper console)`: Loads from binary format
- `SaveToBinary(Player player, string filePath)`: Saves to binary format
- `LoadFromJson(string filePath)`: Loads from JSON format
- `SaveToJson(Player player, string filePath)`: Saves to JSON format

### 2. BinaryOrderAttribute
- Applied to properties to control serialization order
- Ensures compatibility with existing binary format
- Example: `[BinaryOrder(1)]` indicates first property to serialize

### 3. Updated Data Classes
- `Player`, `Equip`, `Style` classes now have `BinaryOrder` attributes
- Properties are automatically serialized in the correct order
- No manual field handling required

## Migration Steps

1. **Replace DataReader calls**:
   ```csharp
   // Old
   Player player = DataReader.ReadFromFile(filePath, console);
   
   // New
   Player player = SaveGameSerializer.LoadFromBinary(filePath, console);
   ```

2. **Replace DataWriter calls**:
   ```csharp
   // Old
   var writer = new DataWriter(player);
   writer.WriteToFile(filePath);
   
   // New
   SaveGameSerializer.SaveToBinary(player, filePath);
   ```

3. **Update JSON handling**:
   ```csharp
   // Old
   JsonHandler.SaveGameToJson(player, jsonPath);
   
   // New (JsonHandler updated to use unified serializer)
   JsonHandler.SaveGameToJson(player, jsonPath);
   // OR directly:
   SaveGameSerializer.SaveToJson(player, jsonPath);
   ```

## Adding New Properties

To add a new property to the Player class:

1. Add the property with appropriate `BinaryOrder` attribute:
   ```csharp
   [BinaryOrder(79)]
   public int NewProperty { get; set; }
   ```

2. That's it! The serializer will automatically handle it.

## Legacy Support

- The old `DataReader` and `DataWriter` classes are still available but deprecated
- `JsonHandler` has been updated to use the unified serializer internally
- Existing code will continue to work during migration

## Performance Considerations

- Reflection has minimal performance impact for save/load operations
- Binary format compatibility is maintained
- JSON serialization uses Newtonsoft.Json for optimal performance

## Testing

Use `SerializationMigrationExample` class to test the migration:
- `OldApproach()`: Shows legacy usage
- `NewApproach()`: Shows unified approach
- `DemonstrateUnifiedApproach()`: Full feature demonstration

## Future Enhancements

- Support for additional serialization formats (XML, etc.)
- Compression support
- Versioning support for backward compatibility
- Custom serialization attributes for complex types