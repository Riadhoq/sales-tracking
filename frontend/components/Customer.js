import { Box, Flex } from "@chakra-ui/react";
import Link from "next/link";

function Customer({ data }) {
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
          Start date - {new Date(data.startDate).toLocaleDateString()}
        </Box>
        <Flex mt="2">
          <Link href={`/customer/${data.customerId}`}>
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
          <Link href={`/customer/edit/${data.customerId}`}>
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

export default Customer;
