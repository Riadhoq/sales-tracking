import { Box, Flex } from "@chakra-ui/react";
import Link from "next/link";

function Salesperson({ data }) {
  return (
    <Box flex="200px" borderWidth="1px" borderRadius="lg" overflow="hidden">
      <Box p="6">
        <Box
          mt="1"
          fontWeight="semibold"
          as="h4"
          lineHeight="tight"
          isTruncated
        >
          {data.firstName}&nbsp;{data.lastName}
        </Box>

        <Box>tel: {data.phone}</Box>

        <Box d="flex" alignItems="center">
          <Box as="span" color="gray.600" fontSize="sm">
            {data.address}
          </Box>
        </Box>
        <Box color="gray.500" fontSize="sm">
          Managed by {data.manager}
        </Box>
        <Box color="gray.500" fontSize="sm">
          Start date - {new Date(data.startDate).toLocaleDateString()}
        </Box>
        <Flex mt="2">
          <Link href={`/salesperson/${data.salespersonId}`}>
            <Box
              borderRadius="sm"
              as="button"
              fontSize="sm"
              px="2"
              py="1"
              bgColor="blue.900"
              color="white"
            >
              Details
            </Box>
          </Link>
          <Link href={`/salesperson/edit/${data.salespersonId}`}>
            <Box
              borderRadius="sm"
              as="button"
              fontSize="sm"
              ml="2"
              px="2"
              py="1"
              bgColor="teal.700"
              color="white"
            >
              Edit
            </Box>
          </Link>
        </Flex>
      </Box>
    </Box>
  );
}

export default Salesperson;
