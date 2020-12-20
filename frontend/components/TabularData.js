import {
  Table,
  TableCaption,
  Tbody,
  Td,
  Thead,
  Tr,
  Th,
  Flex,
} from "@chakra-ui/react";

const TabularData = ({ caption, headers, values }) => {
  return (
    <Flex overflow="auto">
      <Table maxW="40rem" ml="auto" mr="auto" width="100%" variant="simple">
        <TableCaption placement="top">{caption}</TableCaption>
        <Thead>
          <Tr>
            {headers.map((header, i) => (
              <Th key={i}>{header}</Th>
            ))}
          </Tr>
        </Thead>
        <Tbody>
          {values.map((item) => (
            <Tr key={item.id}>
              {item.map((value) => (
                <Td key={item.id + value}>{value}</Td>
              ))}
            </Tr>
          ))}
        </Tbody>
      </Table>
    </Flex>
  );
};

export default TabularData;
