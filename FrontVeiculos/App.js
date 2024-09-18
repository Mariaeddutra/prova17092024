import React, { useState } from 'react';
import { View, Text, FlatList, TouchableOpacity, StyleSheet } from 'react-native';

function VeiculoAccessorios() {
  const [accessories, setAccessorios] = useState([
    { id: 1, name: 'Rodas de liga leve' },
    { id: 2, name: 'Pneus de inverno' },
    { id: 3, name: 'Spoiler' },
    // ...
  ]);

  const [selectedAccessorios, setSelectedAccessorios] = useState([]);

  const handleAddAccessory = (accessorio) => {
    setSelectedAccessories((Accessorios) => [...Accessorios, accessorio]);
  };

  const handleRemoveAccessory = (accessorio) => {
    setSelectedAccessories((Accessorios) =>
      prevAccessories.filter((a) => a.id !== accessorio.id)
    );
  };

  return (
    <View style={styles.container}>
      <Text style={styles.title}>Acessórios de Veículos</Text>
      <FlatList
        data={accessories}
        renderItem={({ item }) => (
          <TouchableOpacity onPress={() => handleAddAccessory(item)}>
            <View style={styles.accessoryItem}>
              <Text style={styles.accessoryName}>{item.name}</Text>
              {selectedAccessories.includes(item) && (
                <Text style={styles.accessorySelected}>Selecionado</Text>
              )}
            </View>
          </TouchableOpacity>
        )}
        keyExtractor={(item) => item.id.toString()}
      />
      <Text style={styles.title}>Acessórios Selecionados</Text>
      <FlatList
        data={selectedAccessories}
        renderItem={({ item }) => (
          <View style={styles.accessorioItem}>
            <Text style={styles.accessorioName}>{item.name}</Text>
            <TouchableOpacity onPress={() => handleRemoveAccessory(item)}>
              <Text style={styles.accessorioRemove}>Remover</Text>
            </TouchableOpacity>
          </View>
        )}
        keyExtractor={(item) => item.id.toString()}
      />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    padding: 20,
  },
  title: {
    fontSize: 24,
    fontWeight: 'bold',
    marginBottom: 10,
  },
  accessoryItem: {
    padding: 10,
    borderBottomWidth: 1,
    borderBottomColor: '#ccc',
  },
  accessoryName: {
    fontSize: 18,
  },
  accessorySelected: {
    fontSize: 14,
    color: 'green',
  },
  accessoryRemove: {
    fontSize: 14,
    color: 'red',
  },
});

export default VeiculoAccessories;