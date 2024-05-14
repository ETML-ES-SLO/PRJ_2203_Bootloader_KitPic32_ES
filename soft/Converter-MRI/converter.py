import re

# Ouvre ficher
with open ("TE_ThermoLm92Uart_withBootloader.hex", "r") as file_to_convert:
    data = file_to_convert.read().splitlines()
# Transforme la liste en un seul string   
data = ''.join(str(e) for e in data)
# Supprime tous les ':' du string
data = data.replace(':', '')
# Creer une liste de paire de char à partir du string
data = re.findall('..', data)
#Initialise string de sortie
converted = ""
# Teste toutes les paires de char du string
for pair in data:
    if(pair == '01'):
        pair = '1001'
    elif(pair == '04'):
        pair = '1004'
    elif (pair == '10'):
        pair = '1010'
    # Ajoute la paire transformee au string final
    converted += pair

# Creer fichier en ecriture
file_converted = open ("TE_ThermoLm92Uart_withBootloader_converted.hex", "w")
# Ecris le string dans le fichier
file_converted.write(converted)