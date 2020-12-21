import { Flex } from "@chakra-ui/react";
import Customer from "../components/Customer";

export default function Customers({ data }) {
  return (
    <Flex px={10} py={10} maxW={800} mx="auto" gridGap="10px" wrap="wrap">
      {data.map((c) => (
        <Customer key={c.customerId} data={c} />
      ))}
    </Flex>
  );
}

Customers.getInitialProps = async (ctx) => {
  const res = await fetch(`${process.env.apiBaseUrl}/customers`);
  const data = await res.json();
  return { data };
};
